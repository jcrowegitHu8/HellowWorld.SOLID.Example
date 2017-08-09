using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.SOLID.Repositories;

namespace HelloWorld.SOLID.Managers
{
	public class MessageRepoCreatorStatic :MessageRepoCreatorBase, IMessageRepoCreatorStatic
	{
		public override IMessageRepository Create()
		{
			return new MessageRepositoryStatic();
		}
	}
}
