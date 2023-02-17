namespace Inventory.Api.Models
{
    public class Product
    {
        public string ProdcutName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Product(string prodcutName, decimal price, string description)
        {
            ProdcutName = prodcutName;
            Price = price;
            Description = description;
        }
    }
}
