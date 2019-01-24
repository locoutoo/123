using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EsteCarII.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace EsteCarIITest
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_ReturnsViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void About_ReturnsViewResult()
        {
            var controller = new HomeController();

            var result = controller.About();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void About_SetsMessageInViewData()
        {
            var controller = new HomeController();

            controller.About();

            Assert.NotNull(controller.ViewData["Message"]);
        }
    }
}
