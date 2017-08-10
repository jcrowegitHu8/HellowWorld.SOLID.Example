using HelloWorld.SOLID.SDK;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.SOLID.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var sdk = new HelloWorldSDK();
				var message = sdk.GetAMessage();
				System.Console.WriteLine(message.Body);
			}
			catch (Exception e)
			{
				System.Console.WriteLine($"An error occurred when trying to get a message {e.Message}");
			}

			System.Console.WriteLine("Press enter to exit.");
			System.Console.ReadLine();

		}
	}
}
