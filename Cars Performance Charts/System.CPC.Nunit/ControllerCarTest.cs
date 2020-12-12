using System.CPC.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CPC.Model.Bean;

namespace System.CPC.Nunit
{
    
    
    /// <summary>
    ///This is a test class for ControllerCarTest and is intended
    ///to contain all ControllerCarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ControllerCarTest
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
        ///A test for ControllerCar Constructor
        ///</summary>
        [TestMethod()]
        public void ControllerCarConstructorTest()
        {
            ControllerCar target = new ControllerCar();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Validate
        ///</summary>
        [TestMethod()]
        public void ValidateTest()
        {
            ControllerCar target = new ControllerCar(); 
            Car car = new Car();
            car.Maker = "Manufacturer X";
            car.Model = "Model Y";
            car.Country = "Spain";
            car.Engine_size = 2999;
            car.Power = 290;
            car.Torque = 370;
            car.Max_speed = 263;

            bool expected = true;
            bool actual;
            actual = target.Validate(car);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateNullTest() 
        {
            ControllerCar target = new ControllerCar();
            Car car = new Car();
            car.Maker = "Manufacturer X";
            car.Model = "Model Y";
            car.Country = "Spain";
            //Null engine size field
            car.Power = 290;
            car.Torque = 370;
            car.Max_speed = 263;

            bool expected = false;
            bool actual;
            actual = target.Validate(car);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateMaxCharTest() 
        {
            string text = "a";

            for (int i = 1; i <= 30; i++) 
            {
                text = text + "a";
            }

            ControllerCar target = new ControllerCar();
            Car car = new Car();
            car.Maker = text;
            car.Model = "Model Y";
            car.Country = "Spain";
            car.Engine_size = 2999;
            car.Power = 290;
            car.Torque = 370;
            car.Max_speed = 263;

            bool expected = false;
            bool actual;
            actual = target.Validate(car);
            Assert.AreEqual(expected, actual);

        }

    }
}
