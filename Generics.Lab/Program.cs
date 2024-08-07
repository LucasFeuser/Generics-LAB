using Generics.Lab;
using Generics.Lab.Models;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var compare = new Comparable<int>();
            var result = compare.Max(4, 5);
            Console.WriteLine("Max value is: " + result);

            var integerDictionary = new GenericDictionary<int, int>();
            integerDictionary.Add(1, 2);

            GenericDictionary<string, Product> objectDictionary = new GenericDictionary<string, Product>();
            var product = new Product();
            product.Category = "new category";
            objectDictionary.Add("myNewProduct", product);
        }
   }
}