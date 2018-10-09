using NUnit.Framework;
using ttt.Controllers;
using TestStack.FluentMVCTesting;
using ttt.Models;
using System;
using System.Net;
using System.Text;
using System.Web.Mvc;

namespace ttt.Tests.Controllers
{
    [TestFixture]
    public class AboutControllerTest
    {
        AboutController sut;

        [SetUp]
        public void Setup()
        => sut = new AboutController();

        [Test]
        public void Index()
        => sut.WithCallTo(c => c.Index())
             .ShouldRenderDefaultView();

        [Test]
        public void NamedView()
        => sut.WithCallTo(c => c.NamedView())
             .ShouldRenderView("OtherView");

        [Test]
        public void ViewWithModel()
        => sut.WithCallTo(c => c.ViewWithModel())
              .ShouldRenderDefaultView().WithModel<Genre>(m =>
                {
                    Console.WriteLine(m.Name);
                    Assert.That(m.Id, Is.EqualTo(1));
                    Assert.That(m.Name, Is.EqualTo("first"));
                });

        [TestCase(1, "first")]
        [TestCase(2, "second")]
        [TestCase(3, "third")]
        [TestCase(4, "not found")]
        public void ViewWithParameter(int id, string result)
        => sut.WithCallTo(c => c.ViewWithParameter(id))
             .ShouldReturnContent(result);

        [Test]
        public void ViewWithStatus()
        => sut.WithCallTo(c => c.ViewWithStatus())
             .ShouldGiveHttpStatus(HttpStatusCode.PaymentRequired);

        [Test]
        public void FileView()
        => sut.WithCallTo(c => c.FileView())
             .ShouldRenderFileContents(Encoding.UTF8.GetBytes("Hello World"), "application/octet-stream");
    }
}

