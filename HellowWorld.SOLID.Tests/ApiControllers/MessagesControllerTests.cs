using FakeItEasy;
using HelloWorld.SOLID.Managers;
using HelloWorld.SOLID.Objects;
using HelloWorld.SOLID.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HellowWorld.SOLID.Tests.ApiControllers
{
	[TestClass]
	public class UnitMessagescontrollerTests
	{
		//TODO show an example unit test for HttpResponseMessage
		/*Show how much more work it takes with HttpResponseMessage*/

		//TODO show an example unit test for IHttpActionResult
		/*Show how much easier it is and asserting for object type when unit testing HttpResponseMessage*/


		[TestMethod]
		public void When_GetAMessage_is_a_static_implementation_it_works()
		{
			/*
			 This test is really useful as it's just a stright pass thru.
			 IMHO this is an example of not a real test as the endpoint is strongly typed
			 so you don't even have to assert the correct return type.
			 */

			//Arrange
			var stringResult = "Hello World!";
			var mockIMessageManager = A.Fake<IMessageManager>();
			A.CallTo(() => mockIMessageManager.GetAMessage()).Returns(new Message{ Body = stringResult});
			var controller = new MessagesController(mockIMessageManager);
			//Act
			var result = controller.Get();

			//Assert
			Assert.IsNotNull(result);
			Assert.IsTrue(!string.IsNullOrWhiteSpace(result.Body));
			Assert.AreEqual(result.Body, stringResult);
		}
	}
}
