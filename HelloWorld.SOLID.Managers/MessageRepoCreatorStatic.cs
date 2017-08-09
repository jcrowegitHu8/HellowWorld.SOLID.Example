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
		/*This is a better pattern for true SOLID programming
		 as it's open for extension and closed for modification.
		 */

		public override IMessageRepository Create()
		{
			return new MessageRepositoryStatic();
		}
	}
}
