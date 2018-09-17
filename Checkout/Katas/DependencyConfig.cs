using Checkout.Contracts;
using Checkout.Services;
using SimpleInjector;

namespace Checkout
{
    public static class DependencyConfig
    {
        public static Container Container { get; private set; }

        public static void Setup()
        {
            Container = new Container();
            Container.Register<ICheckout, Services.Checkout>();
            Container.Register<IInventoryService, InventoryService>(Lifestyle.Singleton);
        }

        public static T GetInstance<T>() where T : class
        {
            return Container.GetInstance<T>();
        }
    }
}
