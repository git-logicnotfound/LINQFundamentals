using LINQFundamentals.DataLayer.EntityClasses;
using LINQFundamentals.DataLayer.RepositoryClasses;

namespace LInqFundamentals.Common;
public class InventoryBase
{
    protected List<Product> GetProducts()
    {
        // Load document
        return ProductRepository.GetAll();
    }

    public void Display(List<Product> products)
    {
        // print product details
        foreach(var product in products)
        {
            Console.Write(product);  
        }
        Console.WriteLine($"Total Products : {products.Count}");
    }
}
