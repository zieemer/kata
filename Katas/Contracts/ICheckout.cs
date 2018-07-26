using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Contracts
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
