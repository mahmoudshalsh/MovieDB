using Xunit;
using ttt.Controllers;
using TestStack.FluentMVCTesting;
using ttt.Models;
using System;
using System.Net;
using System.Text;
using System.Web.Mvc;

namespace ttt.Tests.Controllers
{
    public class AboutControllerTest2
    {
        AboutController sut;

        public AboutControllerTest2()
        => sut = new AboutController();

        [Fact]
        public void Index()
        {
            var view = sut.Index();
            var viewresult = Assert.IsType<ViewResult>(view);
        }
    }
}

