using System.ComponentModel.DataAnnotations;

namespace CourseRegistrationForm.Models;

public sealed class CourseRegistrationModel
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

    [Required(ErrorMessage = "Please select a course.")]
    public string? Course { get; set; }

    [Required(ErrorMessage = "Please select a study mode.")]
    public string? StudyMode { get; set; }

    [Required(ErrorMessage = "Please select a start date.")]
    public DateTime? PreferredStartDate { get; set; }

    public string? Comments { get; set; }

    [MustBeTrue(ErrorMessage = "You must agree before submitting.")]
    public bool AgreeToTerms { get; set; }
}

public sealed class MustBeTrueAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) =>
        value is bool isChecked && isChecked;
}
