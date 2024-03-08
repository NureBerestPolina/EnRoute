using EnRoute.Domain.Models;
using EnRoute.Domain;

namespace EnRoute.API.Controllers
{
    public class PickupCountersController : ODataControllerBase<PickupCounter>
    {
        public PickupCountersController(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
