using Adapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    [TestFixture]
    public class TestClass
    {
            [Test]
            public void WhenConvertingMPHToKMPH_thenSuccessfullyConverted()
            {
                Movable bugattiVeyron = new BugattiVeyron();
                MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
                Assert.AreEqual(bugattiVeyronAdapter.GetSpeed(), 431.30312,0.00001);
            }
            [Test]
            public void WhenConvertingKPHToEuro_thenSuccessfullyConverted()
            {
                Movable bugattiVeyron = new BugattiVeyron();
                MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
                Assert.AreEqual(bugattiVeyronAdapter.GetPrice(),119,0.00001);
            }
    }


}

