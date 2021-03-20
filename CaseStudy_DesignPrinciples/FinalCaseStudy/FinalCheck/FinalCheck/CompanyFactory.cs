using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheck
{
    public interface CompanyFactory
    {
        void MakeElectronicOrder(Channel channel, ProductType productType);
        void MakeFurnitureOrder(Channel channel, ProductType productType);
        void MakeToyOrder(Channel channel, ProductType productType);
    }
}
