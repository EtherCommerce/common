using System;
using System.Linq;
using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class Customer : ContentLifeTimeBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsSystemAccount { get; set; }

        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string LastIpAddress { get; set; }
        
        public int? DefaultShippingAddressId { get; set; }
        public CustomerAddress DefaultShippingAddress { get; set; }
        public int? DefaultBillingAddressId { get; set; }
        public CustomerAddress DefaultBillingAddress { get; set; }

        public bool NewsSubscribtionEnabled { get; set; }
        
        public DateTime? LastLoginAtUtc { get; set; }
        public DateTime LastActivityAtUtc { get; set; }
        public string AdminComment { get; set; }

        public string FullName => $"{LastName} {FirstName}";
        public string ShortName => LastName + !string.IsNullOrWhiteSpace(FirstName) ?? $" {FirstName.First()}.";

        public IList<CustomerAddress> Addresses { get; set; }
        public IList<CustomerRole> Roles { get; set; }
    }
    

    public class SystemAccount : Customer
    {
    }


    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}