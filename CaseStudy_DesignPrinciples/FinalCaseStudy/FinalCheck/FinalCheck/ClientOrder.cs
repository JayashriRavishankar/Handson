using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheck
{
    public class ClientOrder
    {
        CompanyFactory _companyFactory;
        public ClientOrder(CompanyFactory companyFactory)
        {
            _companyFactory = companyFactory;
        }

        public void BuildElectronicOrder(Channel channel)
        {

            _companyFactory.MakeElectronicOrder(channel, ProductType.Electronic);
        }
        public void BuildFurnitureOrder(Channel channel)
        {

            _companyFactory.MakeFurnitureOrder(channel, ProductType.Furniture);
        }
        public void BuildToyOrder(Channel channel)
        {

            _companyFactory.MakeToyOrder(channel, ProductType.Toy);

        }

    }
}

