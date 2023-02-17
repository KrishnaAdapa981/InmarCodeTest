using Inventory.Api.Models;
using System.Collections.Generic;

namespace Inventory.Api.Services
{
    public interface IOfferService
    {
        List<Product> GetAllProducts();
        Dictionary<string, List<Product>> GetTodaysOffers();
    }
}