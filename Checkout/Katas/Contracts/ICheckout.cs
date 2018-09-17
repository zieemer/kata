﻿namespace Checkout.Contracts
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
