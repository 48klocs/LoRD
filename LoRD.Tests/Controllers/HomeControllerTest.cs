using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using LoRD;
using LoRD.Controllers;

namespace LoRD.Tests
{
	[TestFixture ()]
	public class HomeControllerTest
	{
		[Test ()]
		public void Index ()
		{
			// Arrange
			HomeController controller = new HomeController ();

			// Act
			ViewResult result = controller.Index () as ViewResult;

			// Assert
			Assert.AreEqual ("Welcome to ASP.NET MVC on Mono!", result.ViewData ["Message"]);
		}
	}
}
