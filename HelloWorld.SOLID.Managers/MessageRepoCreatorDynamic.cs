using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.SOLID.Managers.Enums;
using HelloWorld.SOLID.Repositories;

namespace HelloWorld.SOLID.Managers
{
	public class MessageRepoCreatorDynamic : MessageRepoCreatorBase, IMessageRepoCreatorDynamic
	{
		/// <summary>
		/// This is to support future data sources but breaks SOLID programming
		/// because we have to modify this class which can break functionality.
		/// </summary>
		/// <returns></returns>
		public override IMessageRepository Create()
		{
			var concreateImplementation = SimpleAppSettingHelper.CurrentAppSettings.Get<int>("MessageRepoSource");
			switch ((MessageRepositorySourceType)concreateImplementation)
			{
				//TODO add addittional cases statements to support future data sources.

				default:
					return new MessageRepositoryStatic();

			}
		}
	}
}
