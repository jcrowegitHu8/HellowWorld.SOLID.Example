using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.SOLID.Managers.Enums
{
	/// <summary>
	/// These are our supported sources
	/// </summary>
	public enum MessageRepositorySourceType
	{
		Static =0,
		TSQL = 1 //TODO implement TSQL repo
        //Future implementation of possible data stores
	}
}
