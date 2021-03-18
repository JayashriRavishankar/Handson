using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
   class Sweets
    {
        
        // Builder uses a complex series of steps

        public void Construct(Builder builder)
        {
            builder.BuildSweets();
            builder.BuildSavory();
        }
    }

    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    abstract class Builder

    {
        public abstract void BuildSweets();
        public abstract void BuildSavory();
        public abstract Product GetResult();
    }

    /// <summary>

    /// The 'ConcreteBuilder1' for child

    /// </summary>

    class ConcreteChild : Builder

    {
        private Product _product = new Product();

        public override void BuildSweets()
        {
            _product.Add("2 sweets are added");
        }

        public override void BuildSavory()
        {
            _product.Add("1 savory are added");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// <summary>

    /// The 'ConcreteBuilder2' for adult

    /// </summary>

    class ConcreteAdult : Builder

    {
        private Product _product = new Product();

        public override void BuildSweets()
        {
            _product.Add("2 sweets are added");
        }

        public override void BuildSavory()
        {
            _product.Add("2 savories are added");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// <summary>

    /// The 'Product' class

    /// </summary>

    class Product

    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {


            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
   
    
