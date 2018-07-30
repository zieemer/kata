using Katas.Contracts;
using Katas.Services;
using SimpleInjector;
using System;
using System.Linq;

namespace Katas
{
    public static class DependencyConfig
    {
        public static Container Container { get; private set; }

        public static void Setup()
        {
            Container = new Container();
            Container.Register<ICheckout, Checkout>();
            Container.Register<IInventoryService, InventoryService>(Lifestyle.Singleton);
        }

        public static T GetInstance<T>() where T : class
        {
            return Container.GetInstance<T>();
        }
    }
}
