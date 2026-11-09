# Customer Contact Form - Blazor Form and Validation

A small Blazor Web App built with .NET 8 and Interactive Server rendering.

## Requirements
- .NET 8 SDK
- Visual Studio 2022 (ASP.NET and web development workload) or the .NET CLI

## Run
1. Extract the ZIP file.
2. Open `CustomerContactForm.csproj` in Visual Studio, or open a terminal in this folder.
3. Run:

   ```bash
   dotnet restore
   dotnet run
   ```

4. Open the local URL printed in the terminal and navigate to `/customer-contact` (or `/`).

## Validation rules
- Full Name: required, minimum 3 characters.
- Email: required, valid email format.
- Phone Number: required, exactly 10 to 12 digits.
- Address: optional; if supplied, minimum 5 characters.
- Message: required, minimum 10 characters.
- Select Service: required; the `Choose...` option has an empty value.
- Terms: must be checked, using a custom `MustBeTrue` validation attribute.

The valid-submit handler currently writes the submitted values to the server console. No database or API is required for this exercise.
