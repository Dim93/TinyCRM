using System;
using System.Linq;
using TinyCrm.Core.Data;
using TinyCrm.Core.Model;
using TinyCrm.Core.Services.Options;

namespace TinyCrm.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private TinyCrmDbContext context_;
        public CustomerService(TinyCrmDbContext context)
        {
            context_ = context;
        }


        //CreateCustomer
        public Customer CreateCustomer(
            CreateCustomerOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var customer = new Customer()
            {
                LastName = options.Lastname,
                FirstName = options.Firstname,
                VatNumber = options.Vatnumber
            };

            context_.Add(customer);

            if (context_.SaveChanges() > 0)
            {
                return customer;
            }

            return null;
        }


        //SearchCustomer
        public IQueryable<Customer> SearchCustomers(
                SearchCustomerOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var query = context_
               .Set<Customer>()
               .AsQueryable();

            if (!string.IsNullOrWhiteSpace(options.FirstName))
            {
                query = query.Where(
                    c => c.FirstName == options.FirstName);
            }

            if (!string.IsNullOrWhiteSpace(options.VatNumber))
            {
                query = query.Where(
                    c => c.VatNumber == options.VatNumber);
            }

            if (options.CustomerId != null)
            {
                query = query.Where(
                    c => c.CustomerId == options.CustomerId.Value);
            }

            if (options.CreateFrom != null)
            {
                query = query.Where(
                    c => c.Created >= options.CreateFrom);
            }

            query = query.Take(500);

            return query;
        }


        //GetCustomerById
        public Customer GetCustomerById(int customerId)
        {
            var customer = SearchCustomers(
                new SearchCustomerOptions()
                {
                    CustomerId = customerId
                }).SingleOrDefault();

            return customer;
        }

        public Customer UpdateCustomer(UpdateCustomerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
