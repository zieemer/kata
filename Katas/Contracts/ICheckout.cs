using System;
using System.Linq;

namespace Katas.Contracts
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
