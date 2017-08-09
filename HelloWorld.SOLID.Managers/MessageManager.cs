using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.SOLID.Repositories;

namespace HelloWorld.SOLID.Managers
{
	/// <summary>
	/// This is the business logic for getting the message
	/// </summary>
    public class MessageManager
	{
		private readonly IMessageRepository _messageRepo;


		public MessageManager(IMessageRepoCreatorStatic messageRepoCreator)
		{
			_messageRepo = messageRepoCreator.Create();
		}

		public string GetAMessage()
		{
			return _messageRepo.GetAMessage();

		}
    }
}
