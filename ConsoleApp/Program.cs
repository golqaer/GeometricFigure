using ConsoleApp.Data;
using GeometricFigure;
using GeometricFigure.Common;
using System.Net.WebSockets;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            var result = context.Products.Select(p => new
            {
                ProductTitle = p.Title,
                Categories = p.Categories.Select(c => c.Title).DefaultIfEmpty(),
            });

            foreach (var r in result)
            {
                Console.WriteLine($"Product title: {r.ProductTitle};\t Categories: {string.Join(", ", r.Categories)}");
            }
        }
    }
}
