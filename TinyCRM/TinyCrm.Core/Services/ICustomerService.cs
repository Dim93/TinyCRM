﻿using System.Linq;
using TinyCrm.Core.Model;
using TinyCrm.Core.Services.Options;

namespace TinyCrm.Core.Services
{
    public interface ICustomerService
    {
        IQueryable<Customer> SearchCustomers(
            SearchCustomerOptions options);

        Customer CreateCustomer(
            CreateCustomerOptions options);

        Customer UpdateCustomer(
            UpdateCustomerOptions options);


    }
}
