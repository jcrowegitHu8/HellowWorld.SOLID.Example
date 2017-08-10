using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.SOLID.Managers;
using HelloWorld.SOLID.Objects;

namespace HelloWorld.SOLID.WebApi.Controllers
{
	//TODO implement security here let's to claims based auth using OWIN and JWT

		/// <summary>
		/// This is just a generic message resource. 
		/// It could be (text,email,task reminder, push notification)
		/// </summary>
	public class MessagesController : ApiController
	{
		private readonly IMessageManager _messageManager;

		public MessagesController(IMessageManager messageManager)
		{
			_messageManager = messageManager;
		}

		public Message Get()
		{
			return _messageManager.GetAMessage();
		}

	}
}
