using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.SOLID.Repositories;

namespace HelloWorld.SOLID.Managers
{
	public abstract class MessageRepoCreatorBase
	{
		public abstract IMessageRepository Create();
	}
}
