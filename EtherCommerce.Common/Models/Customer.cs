﻿using System;
using System.Collections.Generic;

namespace EtherCommerce.Common.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Login { get; set; }

        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string LastIpAddress { get; set; }
        
        public int? DefaultShippingAddressId { get; set; }
        public CustomerAddress DefaultShippingAddress { get; set; }
        public int? DefaultBillingAddressId { get; set; }
        public CustomerAddress DefaultBillingAddress { get; set; }
        public IList<CustomerAddress> UserAddresses { get; set; } = new List<CustomerAddress>();

        public bool NewsSubscribtionEnabled { get; set; }

        public string AdminComment { get; set; }
        public bool IsSystemAccount { get; set; }

        public DateTime CreatedAtUtc { get; set; }
        public DateTime LastUpdateAtUtc { get; set; }
        public DateTime? LastLoginAtUtc { get; set; }
        public DateTime LastActivityAtUtc { get; set; }
        public bool IsDeleted { get; set; }
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