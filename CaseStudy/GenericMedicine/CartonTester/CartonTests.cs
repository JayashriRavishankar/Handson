using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CartonTester
{
    [TestFixture]
    public class CartonTests
    {
        private Program program;
        [SetUp]
        public void SetUp()
        {
            program = new Program();

        }

        private static Medicine GetMedicineObject(string s)
         {
          
            if (s.Equals("Medicine"))
                {
                    return new Medicine()
                    {
                        Name = "Item1",
                        GenericMedicineName = "Name1",
                        Composition = "Comp1",
                        ExpiryDate = new DateTime(2022, 12, 1),
                        PricePerStrip = 80
                    };
                }
                else
                {
                    return null;
                }

         }
        [Test]
        [TestCase(67, "2022/07/09", "Chennai", "Medicine")]
        public void CartonDetail_Called_CreateAndReturnObject(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Medicine m;
            m = GetMedicineObject(key);
          
                CartonDetail result = program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress,m);
                Assert.That(result.MedicineStripCount, Is.EqualTo(medicineStripCount));
                Assert.That(result.RetailerAddress, Is.EqualTo(retailerAddress));
                Assert.That(result.LaunchDate, Is.EqualTo(launchDate));
                Assert.That(result.Medicine, Is.EqualTo(m));
          
        }


            [Test]
            [TestCase(5, "2022/11/6", "Chennai", "Medicine")]
            [TestCase(-1, "2022/6/7", "Mumbai", "Medicine")]
            public void CreateCartonDetail_WhenCalledWithLessThanZeroStripCount_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
            {
              
                Medicine m;
                m = GetMedicineObject(key);

                var exception = Assert.Throws<Exception>(() => program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
                Assert.AreEqual("Incorrect strip count. Please check", exception.Message);

            }

            [Test]
            [TestCase(5, "2024/11/6", "Chennai", "Medicine")]
            [TestCase(1, "2021/3/7", "Mumbai", "Medicine")]
            public void CreateCartonDetail_WhenCalledWithLaunchDateLessThanCurrentDate_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
            {
               
                Medicine m;
                m = GetMedicineObject(key);

                var exception = Assert.Throws<Exception>(() => program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
                Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);

            }


            [Test]
            [TestCase(5, "2022/11/6", "Chennai", "Medicine")]
            [TestCase(6, "2022/6/7", "Mumbai", "Empty")]
           
            public void CreateCartonDetail_WhenCalledEmptyMedicine_ReturnsEmptyCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
            {
               
                Medicine m;
                m = GetMedicineObject(key);

                CartonDetail result = program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
                Assert.That(result, Is.EqualTo(null));

            }
        
    }
}
