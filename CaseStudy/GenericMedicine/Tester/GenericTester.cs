using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
   [TestFixture]
    public class GenericTester
    {
        private Program program;

        [SetUp]
        public void SetUp()
        {
            program = new Program();

        }
        [Test]
        [TestCase("Item1", "Name", "Comp1", "2022/7/8", 78.8)]
        [TestCase("Item2", "Name2", "Comp2", "2023/7/4", 67.87)]

        public void CreateMedicineDetail_WhenCalled_ReturnMedicineObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var result = program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
            Assert.That(result.Composition, Is.EqualTo(composition));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));
        }


        [Test]
        [TestCase(" Item1", "Name1", "Comp1", "2022/6/3", 12)]
        [TestCase(" Item1", "", "Comp1", "2022/6/3", 12)]
        public void CreateMedicineDetail_WhenCalledWithEmptyMedName_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var exception = Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));

            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exception.Message);

        }

        [Test]
        [TestCase("Item1", "Name1", "Comp1", "2021/9/9", 8.6)]
        [TestCase("Item1", "Name1", "Comp1", "2022/9/9", -8.6)]
        [TestCase("Item2", "Name2", "Comp2", "2023/11/13", -0.09)]
        public void CreateMedicineDetail_WhenPriceLessThanZero_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var exception = Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
        }


        [Test]
        [TestCase("Item1", "Name1", "Comp1", "2023/9/9", 8.6)]
        [TestCase("Item1", "Name1", "Comp1", "1998/12/19", 12)]
        [TestCase("Item2", "Name2", "Comp2", "2001/7/6", 11.9)]
        public void CreateMedicineDetail_WhenLaunchDateLessThanCurrentDate_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var exception = Assert.Throws<Exception>(() => program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}

    

