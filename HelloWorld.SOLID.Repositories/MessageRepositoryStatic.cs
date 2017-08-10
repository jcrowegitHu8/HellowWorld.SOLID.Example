using HelloWorld.SOLID.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.SOLID.Repositories
{
	/// <summary>
	/// Repo to get messages to display.  We could create implementations for TSQL, NO SQL, Queue, etc
	/// but currently we are just going to dumby up the data hard coded style.
	/// </summary>
    public class MessageRepositoryStatic : IMessageRepository
	{
	    public Message GetAMessage()
	    {
		    return new Message
		    {
			    Body = "Hello World!"
		};
	    }
    }
}
