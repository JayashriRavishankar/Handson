using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheck
{
    public enum ProductType
    {
        Electronic, Furniture, Toy
    }
    public enum Channel
    {
        Ecommerce, Tele
    }
    public abstract class Order
    {
        public Order(ProductType productType, Channel channel)
        {
            this.ProductType = productType;
            this.Channel = channel;
        }

        public abstract void Construct();

        public ProductType ProductType { get; set; }
        public Channel Channel { get; set; }

        public override string ToString()
        {
            return "Product is " + ProductType.ToString() +  " ordered through " + Channel.ToString();
        }
    }

    public class ElectronicOrder : Order
    {
        public ElectronicOrder(ProductType productType, Channel channel) : base(ProductType.Electronic, channel)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("***  Ordering a electronic product  ***");
            Console.WriteLine(base.ToString());
        }
    }

    public class FurnitureOrder : Order
    {
        public FurnitureOrder(ProductType productType, Channel channel) : base(ProductType.Furniture, channel)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("***  Ordering a Furniture  ***");
            Console.WriteLine(base.ToString());
        }
    }

    public class ToyOrder : Order
    {
        public ToyOrder(ProductType productType, Channel channel) : base(ProductType.Toy, channel)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("***  Ordering a Toy  ***");
            Console.WriteLine(base.ToString());
        }
    }


}


