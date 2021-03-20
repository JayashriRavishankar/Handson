using System;

namespace FinalCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            CompanyFactory companyFactory = new ConcreteCompanyFactory();
            ClientOrder clientorder = new ClientOrder(companyFactory);
            clientorder.BuildElectronicOrder(Channel.Tele);
            clientorder.BuildFurnitureOrder(Channel.Ecommerce);
            clientorder.BuildToyOrder(Channel.Tele);

            Console.ReadKey();
        }
    }
}
