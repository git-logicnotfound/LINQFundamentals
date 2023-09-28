using System.Text;

namespace LINQFundamentals.DataLayer.EntityClasses;
public class Product
{
   public int ProductID { get; set; }
   public string Name { get; set; }
   public string Color { get; set; }
   public decimal StandardCost { get; set; }
   public decimal ListPrice { get; set; }
   public string Size { get; set; }

   public override string ToString()
   {
      StringBuilder stringBuilder = new(1024);
      stringBuilder.AppendLine($"Product Id - {ProductID}");
      stringBuilder.AppendLine($"Name : {Name}");
      stringBuilder.AppendLine($"StandardCost : {StandardCost} - ListPrice : {ListPrice}");
      stringBuilder.AppendLine($"Size : {Size}");
      stringBuilder.AppendLine();

      return stringBuilder.ToString();
   }
}
