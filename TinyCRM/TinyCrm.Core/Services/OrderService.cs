using System;
using System.Linq;
using TinyCrm.Core.Data;
using TinyCrm.Core.Model;
using TinyCrm.Core.Services.Options;

namespace TinyCrm.Core.Services
{
    public class OrderService : IOrderService
    {
        private TinyCrmDbContext context_;
        private CustomerService customerservice_;

        public OrderService(TinyCrmDbContext context, 
            ICustomerService customerservice)
        {
            context_ = context;
            //customerservice_ = customerservice;
        }


        //CreateOrder
        public Order CreateOrder(
            CreateOrderOptions options)
        {
            if (options == null)
            {
                return null;
            }

            var customer = customerservice_.SearchCustomers(
                new SearchCustomerOptions
            {
                CustomerId = options.CustomerId

            }).SingleOrDefault();

            if (customer == null)
            {
                return null;
            }
            var order = new Order();
            customer.Orders.Add(order);
            return null;  // error : not all paths have a return value;

            /*
            foreach (var item in options.ProductIds)
            {
                //var product = ProductService
                
            } */
            
        }


        //SearchOrder
        public IQueryable<Order> SearchOrder(SearchOrderOptions options)
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder(UpdateOrderOptions options)
        {
            return null;
        }
    }
}
