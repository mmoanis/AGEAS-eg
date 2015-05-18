using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGEAS_iteration1;
using AGEAS_iteration1.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test the initialization of the controller and sql server.
        /// </summary>
        [TestMethod]
        public void ControllerInstanceInitialization()
        {
            Controller controller = Controller.Instance;
            Assert.AreNotEqual(controller, null);
        }

        /// <summary>
        /// see TC-001
        /// </summary>
        [TestMethod]
        public void LoginTest1()
        {
            Controller controller = Controller.Instance;
            bool result = controller.Form1LoginButtonPressed("", "");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// see TC-002
        /// </summary>
        [TestMethod]
        public void LoginTest2()
        {
            Controller controller = Controller.Instance;
            bool result = controller.Form1LoginButtonPressed("", "admin");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// see TC-003
        /// </summary>
        [TestMethod]
        public void LoginTest3()
        {
            Controller controller = Controller.Instance;
            bool result = controller.Form1LoginButtonPressed("", "user");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// see TC-004
        /// </summary>
        [TestMethod]
        public void LoginTest4()
        {
            Controller controller = Controller.Instance;
            bool result = controller.Form1LoginButtonPressed("admin", "user");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// see TC-010
        /// <remarks>Null pointer here referes to the invokation of a form that is not initialized</remarks>
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void LoginTest5()
        {
            Controller controller = Controller.Instance;
            bool result = controller.Form1LoginButtonPressed("admin", "admin");
        }

        /// <summary>
        /// TC-014
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddTest1()
        {
            Controller controller = Controller.Instance;
            controller.InsertProduct(3, "", 0, 0);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddTest()
        {
            Controller controller = Controller.Instance;
            controller.InsertCustomer("", "", 0);
        }
    }
}
