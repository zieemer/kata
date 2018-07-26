using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Contracts;
using Katas.Services;
using SimpleInjector;

namespace Katas
{
    public static class DependencyConfig
    {
        public static Container Container { get; private set; }

        public static void Setup()
        {
            Container = new Container();
            Container.Register<ICheckout, Checkout>();
        }

        public static T GetInstance<T>() where T : class
        {
            return Container.GetInstance<T>();
        }
    }
}
