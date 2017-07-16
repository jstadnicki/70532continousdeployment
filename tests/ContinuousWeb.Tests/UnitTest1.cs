using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousDeployment.Controllers;

namespace ContinuousWeb.Tests
{
     [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
