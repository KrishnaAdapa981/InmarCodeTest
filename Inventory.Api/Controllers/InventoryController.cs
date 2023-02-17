using Inventory.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Controllers
{
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private IOfferService _offerService { get; }

        public InventoryController(IOfferService offerService) {
            _offerService = offerService;
        }

        [HttpGet("Inventory/GetTodaysOffers")]
        public async Task<ActionResult> GetTodaysOffers()
        {
            return Ok(await Task.Run(() =>
            {
                return _offerService.GetTodaysOffers();
            }));
        }

        [HttpGet("Inventory/GetAllProducts")]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await Task.Run(() =>
            {
                return _offerService.GetAllProducts().OrderBy(x => x.Price).Take(3);
            }));
        }

        [HttpGet("Inventory/GetSecondHighestProduct")]
        public async Task<ActionResult> GetSecondHighestProduct()
        {
            return Ok(await Task.Run(() =>
            {
                return _offerService.GetAllProducts().OrderBy(x => x.Price).ToList()[1];
            }));
        }

    }
}
