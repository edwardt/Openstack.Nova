namespace Openstack.Nova.Client.Console
{
	using System;
	using System.Diagnostics;
	using System.IO;
	using Openstack.Nova.Client;
	using ServiceStack.Configuration;
	using ServiceStack.DesignPatterns;
	using ServiceStack.Logging;

	class Entry
	{
		ILog logger;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			using () {
				while(Console.ReadLine())
				{

				}
			}

		}
	}
}
