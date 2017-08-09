using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.SOLID.Managers;

namespace HelloWorld.SOLID.WebApi.Controllers
{
	public class MessagesController : ApiController
	{
		private readonly IMessageManager _messageManager;

		public MessagesController(IMessageManager messageManager)
		{
			_messageManager = messageManager;
		}

		public string Get()
		{
			return _messageManager.GetAMessage();
		}

	}
}
