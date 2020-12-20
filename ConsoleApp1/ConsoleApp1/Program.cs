using System;
using System.Threading;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("starting...");
			Thread.Sleep(2000);
			Console.WriteLine("ending...");
			Thread.Sleep(1000);
		}
	}
}
