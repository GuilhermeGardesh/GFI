using Microsoft.AspNetCore.Identity;
using GFI.Domain.Commom.Entities;
using GFI.Domain.Commom.Enums;
using GFI.Domain.FinancialManagement.Budgets;

namespace GFI.Application.Identity.Users
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser(
            string userName,
            string firstName,
            string lastName,
            string email,
            string password,
            string phoneNumber,
            UserPreferences preferences,
            string document,
            DocumentType documentType)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Preferences = preferences;
            Person.Document = document;
            Person.DocumentType = documentType;
            IsActive = true;
        }

        public string FirstName { get; private set; } = default!;
        public string LastName { get; private set; } = default!;
        public bool IsActive { get; private set; } = default!;
        public UserPreferences Preferences { get; private set; } = default!;
        public Person Person { get; private set; } = default!;
        public List<Budget> Budgets { get; set; }
    }

    public class UserPreferences
    {

    }
}
