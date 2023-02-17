using Inventory.Api.Models;
using System;
using System.Collections.Generic;

namespace Inventory.Api.Services
{
    public class OfferService : IOfferService
    {
        private List<Product> Inventory;

        public OfferService()
        {
            Inventory = GetInventory();
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public Dictionary<string, List<Product>> GetTodaysOffers()
        {
            var result = new Dictionary<string, List<Product>>();
            for (int i = 1; i <= 4; i++)
            {
                result.Add($"ComboPackage{i}", GetThreeRandomProducts());
            }
            return result;
        }

        private List<Product> GetInventory()
        {
            return new List<Product>
            {
                new Product("P1", 1000, "P1 Desc"),
                new Product("P2", 200, "P2 Desc"),
                new Product("P3", 400, "P3 Desc"),
                new Product("P4", 700, "P4 Desc"),
                new Product("P5", 600, "P5 Desc"),
                new Product("P6", 800, "P6 Desc")
            };

        }

        private List<Product> GetThreeRandomProducts()
        {
            var result = new List<Product>();

            for (int i = 0; i < 3; i++)
            {
                Random r = new Random();
                int rInt = r.Next(0, 5);
                result.Add(Inventory[rInt]);
            }

            return result;
        }

    }
}
