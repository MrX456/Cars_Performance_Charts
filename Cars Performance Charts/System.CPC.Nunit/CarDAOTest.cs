using System.CPC.Model.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SQLite;
using System.CPC.Model.Bean;
using System.Collections.Generic;
using System.CPC.Controller;

namespace System.CPC.Nunit
{
    
    
    /// <summary>
    ///This is a test class for CarDAOTest and is intended
    ///to contain all CarDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarDAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CarDAO Constructor
        ///</summary>
        [TestMethod()]
        public void CarDAOConstructorTest()
        {
            CarDAO target = new CarDAO();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for FindAll
        ///</summary>
        [TestMethod()]
        public void FindAllTest()
        {
            CarDAO target = new CarDAO(); 
            DataTable expected = null;
            DataTable actual;
            actual = target.FindAll();
            Assert.AreNotEqual(expected, actual);
            //We have three cars stored
            Assert.AreEqual(2, actual.Rows.Count);
            
        }

        /// <summary>
        ///A test for FindCar
        ///</summary>
        [TestMethod()]
        public void FindCarTest()
        {
            CarDAO target = new CarDAO();
            int id = 1;
            SQLiteDataReader expected = null;
            SQLiteDataReader actual;
            actual = target.FindCar(id);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual("Model A", actual["model"]);
        }

        /// <summary>
        ///A test for FindModelLike
        ///</summary>
        [TestMethod()]
        public void FindModelLikeTest()
        {
            CarDAO target = new CarDAO(); 
            string modelLike = "a";
            DataTable expected = null;
            DataTable actual;
            actual = target.FindModelLike(modelLike);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(1,actual.Rows.Count);
        }

        /// <summary>
        ///A test for Remove
        ///</summary>
        [TestMethod()]
        public void RemoveTest()
        {
            CarDAO target = new CarDAO(); 
            int id = 3;
            target.Remove(id);

            SQLiteDataReader car = target.FindCar(id);
            Assert.IsNull(car);
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            CarDAO target = new CarDAO();
            Car car1 = new Car();
            car1.Maker = "Manufacturer A";
            car1.Model = "Model A";
            car1.Country = "USA";
            car1.Year = 2020;
            car1.Engine_size = 4699;
            car1.Power = 450;
            car1.Torque = 442;
            car1.Max_speed = 295;
            car1.Price = 89900.00M;

            Car car2 = new Car();
            car2.Maker = "Manufacturer B";
            car2.Model = "Model B";
            car2.Country = "UK";
            car2.Year = 2016;
            car2.Engine_size = 3499;
            car2.Power = 305;
            car2.Torque = 490;
            car2.Max_speed = 250;
            car2.Price = 76000.00M;

            Car car3 = new Car();
            car3.Maker = "Manufacturer C";
            car3.Model = "Model C";
            car3.Country = "Japan";
            car3.Year = 2011;
            car3.Engine_size = 1998;
            car3.Power = 245;
            car3.Torque = 290;
            car3.Max_speed = 235;
            car3.Price = 19900.00M;

            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            ControllerCar ctr = new ControllerCar();

            foreach (Car c in cars)
            {
                if (ctr.Validate(c)) 
                {
                    Car expected = null;
                    Car actual;
                    actual = target.Save(c);
                    Assert.AreNotEqual(expected, actual);
                }
            }
        }

         /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            CarDAO target = new CarDAO();
            Car car2 = new Car();
            car2.Id = 2;
            car2.Maker = "Manufacturer B";
            car2.Model = "Model B";
            car2.Country = "Japan";
            car2.Year = 2004;
            car2.Engine_size = 1998;
            car2.Power = 230;
            car2.Torque = 305;
            car2.Max_speed = 240;
            car2.Price = 17500.00M;

            ControllerCar ctr = new ControllerCar();

            if (ctr.Validate(car2))
            {
                Car expected = null;
                Car actual;
                actual = target.Save(car2);
                Assert.AreNotEqual(expected, actual);
                Assert.AreEqual("Japan", actual.Country);
            }
        }

       
        /// <summary>
        ///A test for TotalCars
        ///</summary>
        [TestMethod()]
        public void TotalCarsTest()
        {
            CarDAO target = new CarDAO();
            int expected = 0;
            int actual;
            actual = target.TotalCars();
            Assert.AreNotEqual(expected, actual);
            
        }


        /// <summary>
        ///A test for SumValueTotalCars
        ///</summary>
        [TestMethod()]
        public void SumValueTotalCarsTest()
        {
            CarDAO target = new CarDAO(); 
            Decimal expected = 0;
            Decimal actual;
            actual = target.SumValueTotalCars();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for AvgValueCars
        ///</summary>
        [TestMethod()]
        public void AvgValueCarsTest()
        {
            CarDAO target = new CarDAO();
            Decimal expected = 0;
            Decimal actual;
            actual = target.AvgValueCars();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for ExpensivestCar
        ///</summary>
        [TestMethod()]
        public void ExpensivestCarTest()
        {
            CarDAO target = new CarDAO();
            string expected = "F1";
            string actual;
            actual = target.ExpensivestCar();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for NewestCar
        ///</summary>
        [TestMethod()]
        public void NewestCarTest()
        {
            CarDAO target = new CarDAO();
            string expected = "R8 4.2 FSI";
            string actual;
            actual = target.NewestCar();
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///A test for TopFiveCarMakers
        ///</summary>
        [TestMethod()]
        public void TopFiveCarMakersTest()
        {
            CarDAO target = new CarDAO(); 
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.TopFiveCarMakers();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for TopFiveCarCountries
        ///</summary>
        [TestMethod()]
        public void TopFiveCarCountriesTest()
        {
            CarDAO target = new CarDAO(); 
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.TopFiveCarCountries();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for BiggestEngine
        ///</summary>
        [TestMethod()]
        public void BiggestEngineTest()
        {
            CarDAO target = new CarDAO();
            Car expected = null;
            Car actual;
            actual = target.BiggestEngine();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual("Challenger RT", actual.Model);
        }

        /// <summary>
        ///A test for AvgEngineSize
        ///</summary>
        [TestMethod()]
        public void AvgEngineSizeTest()
        {
            CarDAO target = new CarDAO(); 
            Decimal expected = new Decimal(); 
            Decimal actual;
            actual = target.AvgEngineSize();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for TopFiveEngineSize
        ///</summary>
        [TestMethod()]
        public void TopFiveEngineSizeTest()
        {
            CarDAO target = new CarDAO();
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.TopFiveEngineSize();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for CustomEngineSizeComparison
        ///</summary>
        [TestMethod()]
        public void CustomEngineSizeComparisonTest()
        {
            CarDAO target = new CarDAO();
            int[] ids = new int[5];
            ids[0] = 10;
            ids[1] = 11;
            ids[2] = 14;
            ids[3] = 16;
            ids[4] = 17;
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.CustomEngineSizeComparison(ids);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for AvgPower
        ///</summary>
        [TestMethod()]
        public void AvgPowerTest()
        {
            CarDAO target = new CarDAO(); 
            Decimal expected = new Decimal();
            Decimal actual;
            actual = target.AvgPower();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for CustomPowerComparison
        ///</summary>
        [TestMethod()]
        public void CustomPowerComparisonTest()
        {
            CarDAO target = new CarDAO();
            int[] ids = new int[5];
            ids[0] = 10;
            ids[1] = 11;
            ids[2] = 14;
            ids[3] = 16;
            ids[4] = 17;
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.CustomPowerComparison(ids);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for PowerfulCar
        ///</summary>
        [TestMethod()]
        public void PowerfulCarTest()
        {
            CarDAO target = new CarDAO();
            Car expected = null;
            Car actual;
            actual = target.PowerfulCar();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual("Enzo", actual.Model);
        }

        /// <summary>
        ///A test for TopFivePower
        ///</summary>
        [TestMethod()]
        public void TopFivePowerTest()
        {
            CarDAO target = new CarDAO();
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.TopFivePower();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for AvgTorque
        ///</summary>
        [TestMethod()]
        public void AvgTorqueTest()
        {
            CarDAO target = new CarDAO(); 
            Decimal expected = new Decimal();
            Decimal actual;
            actual = target.AvgTorque();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for CustomTorqueComparison
        ///</summary>
        [TestMethod()]
        public void CustomTorqueComparisonTest()
        {
            CarDAO target = new CarDAO();
            int[] ids = new int[5];
            ids[0] = 10;
            ids[1] = 11;
            ids[2] = 14;
            ids[3] = 16;
            ids[4] = 17;
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.CustomTorqueComparison(ids);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for TopFiveTorque
        ///</summary>
        [TestMethod()]
        public void TopFiveTorqueTest()
        {
            CarDAO target = new CarDAO();
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.TopFiveTorque();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for MostTorqueCar
        ///</summary>
        [TestMethod()]
        public void MostTorqueCarTest()
        {
            CarDAO target = new CarDAO();
            Car expected = null;
            Car actual;
            actual = target.MostTorqueCar();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual("Challenger RT", actual.Model);
        }

        /// <summary>
        ///A test for AvgMaxSpeed
        ///</summary>
        [TestMethod()]
        public void AvgMaxSpeedTest()
        {
            CarDAO target = new CarDAO();
            Decimal expected = new Decimal();
            Decimal actual;
            actual = target.AvgMaxSpeed();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for FastestCar
        ///</summary>
        [TestMethod()]
        public void FastestCarTest()
        {
            CarDAO target = new CarDAO();
            Car expected = null;
            Car actual;
            actual = target.FastestCar();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual("F1", actual.Model);
        }

        /// <summary>
        ///A test for CustomMaxSpeedComparison
        ///</summary>
        [TestMethod()]
        public void CustomMaxSpeedComparisonTest()
        {
            CarDAO target = new CarDAO();
            int[] ids = new int[5];
            ids[0] = 10;
            ids[1] = 11;
            ids[2] = 14;
            ids[3] = 16;
            ids[4] = 17;
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.CustomMaxSpeedComparison(ids);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }

        /// <summary>
        ///A test for TopFiveMaxSpeed
        ///</summary>
        [TestMethod()]
        public void TopFiveMaxSpeedTest()
        {
            CarDAO target = new CarDAO();
            Dictionary<string, int> expected = null;
            Dictionary<string, int> actual;
            actual = target.TopFiveMaxSpeed();
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(5, actual.Count);
        }
    }
}
