using System.ComponentModel.DataAnnotations;

namespace CustomerContactForm.Models;

public sealed class CustomerContactModel
{
    [Required(ErrorMessage = "Full name is required.")]
    [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required.")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [MinLength(5, ErrorMessage = "Address must be at least 5 characters long.")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Message is required.")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
    public string Message { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a service.")]
    public string Service { get; set; } = string.Empty;

    [MustBeTrue(ErrorMessage = "You must agree before submitting.")]
    public bool AgreeToTerms { get; set; }
}

public sealed class MustBeTrueAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) => value is true;
}
