using System.Linq;
using TinyCrm.Core.Model;
using TinyCrm.Core.Services.Options;

namespace TinyCrm.Core.Services
{
    public interface IOrderService
    {
        Order CreateOrder(
            CreateOrderOptions options);

        Order UpdateOrder(
            UpdateOrderOptions options);

        IQueryable<Order> SearchOrder(
            SearchOrderOptions options);


    }
}
