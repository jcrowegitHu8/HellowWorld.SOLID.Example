using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.SOLID.Objects
{
	/// <summary>
	/// A message representing a generic wrapper to be defined/extened
	/// in future use.
	/// </summary>
    public class Message
    {
		public string Id { get; set; }
		public string Body { get; set; }
    }
}
