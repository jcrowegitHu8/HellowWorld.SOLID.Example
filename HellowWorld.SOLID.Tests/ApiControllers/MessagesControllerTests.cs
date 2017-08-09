using FakeItEasy;
using HelloWorld.SOLID.Managers;
using HelloWorld.SOLID.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HellowWorld.SOLID.Tests.ApiControllers
{
	[TestClass]
	public class UnitMessagescontrollerTests
	{
		[TestMethod]
		public void When_GetAMessage_is_a_static_implementation()
		{
			/*
			 This test is really useful as it's just a stright pass thru.
			 IMHO this is an example of not a real test as the endpoint is strongly typed
			 so you don't even have to assert the correct return type.
			 */

			//Arrange
			var stringResult = "Hello World!";
			var mockIMessageManager = A.Fake<IMessageManager>();
			A.CallTo(() => mockIMessageManager.GetAMessage()).Returns(stringResult);
			var controller = new MessagesController(mockIMessageManager);
			//Act
			var result = controller.Get();

			//Assert
			Assert.IsTrue(!string.IsNullOrWhiteSpace(result));
			Assert.AreEqual(result, "Hello World!");
		}
	}
}
