using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.SOLID.Repositories
{
	/// <summary>
	/// Repo to get messages to display.  We could create implementations fromcome from TSQL, NO SQL, Queue, etc
	/// </summary>
    public class MessageRepositoryStatic : IMessageRepository
	{
	    public string GetAMessage()
	    {
		    return "Hello World!";
	    }
    }
}
