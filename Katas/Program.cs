using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Katas.Contracts;
using Katas.Models;
using Katas.Services;

namespace Katas
{
    class Program
    {

        private static IInventoryService _inventoryService;
        private static ICheckout _checkout;
        
        static void Main(string[] args)
        {

            DependencyConfig.Setup();
            _inventoryService = DependencyConfig.GetInstance<IInventoryService>();
            _inventoryService.SeedStock();

            _checkout = DependencyConfig.GetInstance<ICheckout>();


            Prompt();




        }

        private static void Prompt()
        {
            Console.WriteLine("");
            Console.WriteLine("Please type in sku to add item to basket or x to exit");

            foreach (var item in _inventoryService.GetAll())
            {
                Console.WriteLine($"SKU: {item.SKU}");
            }

            var sku = Console.ReadKey().Key.ToString();
            Console.WriteLine();
            if(sku!="X") ShowBasket(sku);
        }

        private static void ShowBasket(string sku)
        {

            _checkout.Scan(sku);
            Console.WriteLine($"Your basket total is: {_checkout.GetTotal()}");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Prompt();

        }
    }
}
