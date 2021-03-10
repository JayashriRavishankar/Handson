using NUnit.Framework;
using MyFoodSupply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodItemTester
{

    [TestFixture]
    public class FoodItemTests
    {
        Program p;
        FoodDetail food;
        [OneTimeSetUp]
        public void Init()
        {
            p = new Program();
            food = new FoodDetail()
            {
                Name = "Item",
                DishType = FoodDetail.Category.MainDish,
                Price = 100.00,
                ExpiryDate = DateTime.Now.AddYears(3)
            };
        }

        [Test]
        [TestCase("Item", FoodDetail.Category.MainDish, 150.00, "03/09/2022")]
        public void CreateFoodDetail_WhenCreated_ReturnObject(string name, int category, double price, DateTime expDate)
        {
            FoodDetail m = null;
            try
            {

                m = p.CreateFoodDetail(name, category, expDate, price);

                Assert.IsNotNull(m);

            }
            catch (Exception)
            {

                Assert.Fail("Food details Object not created successfully");
            }

        }
        [Test]
        [TestCase("", FoodDetail.Category.MainDish, 150.00, "03/09/2021")]
       // [TestCase("Item1", FoodDetail.Category.MainDish, 150.00, "03/09/2021")]
        public void CreateFoodDetail_FoodItemIsEmpty_ExpectedException(string name, int category, double price, DateTime expDate)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, category, expDate, price));

            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Item", FoodDetail.Category.MainDish, -100.00, "03/09/2021")]
        //[TestCase("Item", FoodDetail.Category.MainDish, 100.00, "03/09/2021")]
        public void CreateFoodDetail_FoodItemPriceBelowZero_ExpectedException(string name, int category, double price, DateTime expDate)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, category, expDate, price));

            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exp.Message);

        }


        [Test]
        [TestCase("Item", FoodDetail.Category.MainDish, 150.00, "01/09/2019")]

        public void CreateFoodDetail_LaunchDateLessThanCurrent_ExpectedException(string name, int category, double price, DateTime expDate)
        {
            var exp = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, category, expDate, price));

            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exp.Message);

        }

        

        //SupplyDetail//


        [Test]
        [TestCase(12, "03/09/2023", "Name1", 40.00)]
        
        public void CreateSupplyDetail_WhenCreated_ReturnObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            SupplyDetail c = null;
            try
            {

                c = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food);
                Assert.IsNotNull(c);
            }
            catch
            {

                Assert.Fail("Supply details Object not created successfully");
            }

        }

        [Test]

        [TestCase(12, "01/09/2019", "Name1", 40.00)]
        [TestCase(12, "01/09/2021", "Name2", 40.00)]


        public void CreateSupplyDetail_LaunchDateLessThanCurrent_ExpectedException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {

            var exp = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));

            Assert.AreEqual("Incorrect food request date. Please provide valid value", exp.Message);
        }


        [Test]
        [TestCase(-15, "01/09/2021", "Name", 40.00)]
        [TestCase(12, "01/09/2021", "Name", 40.00)]
        public void CreateSupplyDetail_ItemCountlessthanZero_ExpectedException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {

            var exp = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));

            Assert.AreEqual("Incorrect food item count. Please check", exp.Message);

        }

        [Test]
        [TestCase(12, "03/09/2021", "Name", 40.00, null)]
 
        public void CreateSupplyDetail_ItemObjectNull_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, FoodDetail food)
        {
            SupplyDetail result = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food);

            Assert.IsNull(result);

        }
    }
}

