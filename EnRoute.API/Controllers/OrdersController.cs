using EnRoute.Domain.Models;
using EnRoute.Domain;

namespace EnRoute.API.Controllers
{
    public class OrdersController : ODataControllerBase<Order>
    {
        public OrdersController(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }


    }
}
