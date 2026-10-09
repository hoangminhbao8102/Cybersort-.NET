public sealed class DIContainer
{
    private readonly Dictionary<Type, Type> _registrations = new();

    // Đăng ký interface hoặc base class → implementation
    public void Register<TService, TImplementation>()
        where TImplementation : TService
    {
        Register(typeof(TService), typeof(TImplementation));
    }

    // Đăng ký class cụ thể
    public void Register<T>() where T : class
    {
        Register(typeof(T), typeof(T));
    }

    private void Register(Type service, Type implementation)
    {
        if (!implementation.IsClass || implementation.IsAbstract)
            throw new ArgumentException(
                $"{implementation.Name} phải là class cụ thể.");

        _registrations[service] = implementation;
    }

    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T), new HashSet<Type>());
    }

    private object Resolve(Type service, HashSet<Type> resolving)
    {
        if (!_registrations.TryGetValue(service, out var implementation))
        {
            if (service == typeof(string))
                return string.Empty;

            if (service.IsValueType)
                return Activator.CreateInstance(service) ?? throw new InvalidOperationException($"Không thể tạo giá trị mặc định cho {service.Name}.");

            throw new InvalidOperationException(
                $"{service.Name} chưa được đăng ký.");
        }

        // Phát hiện dependency vòng: A → B → A
        if (!resolving.Add(service))
            throw new InvalidOperationException(
                $"Dependency vòng tại {service.Name}.");

        try
        {
            var constructors = implementation.GetConstructors();

            // Quy ước đơn giản: mỗi class có đúng một public constructor
            if (constructors.Length != 1)
                throw new InvalidOperationException(
                    $"{implementation.Name} phải có đúng một public constructor.");

            var constructor = constructors[0];

            var arguments = constructor.GetParameters()
                .Select(parameter =>
                {
                    if (_registrations.TryGetValue(parameter.ParameterType, out var parameterImplementation))
                        return Resolve(parameterImplementation, resolving);

                    if (parameter.HasDefaultValue)
                        return parameter.DefaultValue ?? (parameter.ParameterType == typeof(string) ? string.Empty : null);

                    if (parameter.ParameterType == typeof(string))
                        return string.Empty;

                    if (parameter.ParameterType.IsValueType)
                        return Activator.CreateInstance(parameter.ParameterType) ?? throw new InvalidOperationException($"Không thể tạo giá trị mặc định cho {parameter.ParameterType.Name}.");

                    throw new InvalidOperationException($"{parameter.ParameterType.Name} chưa được đăng ký và không có giá trị mặc định.");
                })
                .ToArray();

            return constructor.Invoke(arguments);
        }
        finally
        {
            resolving.Remove(service);
        }
    }
}
