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
        foreach (var product in products)
        {
            Console.Write(product);
        }
        Console.WriteLine($"Total Products : {products.Count}");
    }

    public void Display(List<string> productNames)
    {
        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine($"Total Products : {productNames.Count}");
    }

    public void Display(string data)
    {
        Console.WriteLine(data);
    }
}
