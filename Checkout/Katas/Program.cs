using Katas.Contracts;
using System;
using System.Linq;

namespace Katas
{
    class Program
    {

        private static IInventoryService _inventoryService;
        private static ICheckout _checkout;

        static void Main()
        {

            DependencyConfig.Setup();
            _inventoryService = DependencyConfig.GetInstance<IInventoryService>();
            _inventoryService.SeedStock();

            _checkout = DependencyConfig.GetInstance<ICheckout>();


            Prompt();




        }

        private static void Prompt()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Please type in SKU [A,B,C,D] to add item to basket or press 'X' to exit");


            var sku = Console.ReadKey().Key.ToString();
            Console.WriteLine();
            if (sku != "X") ShowBasket(sku);
        }

        private static void ShowBasket(string sku)
        {

            _checkout.Scan(sku);
            Console.WriteLine($" Total is: {_checkout.GetTotal()}        |");
            Console.WriteLine("----------------------|");
            Console.WriteLine();

            Prompt();

        }
    }
}
