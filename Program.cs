// HelloUser main routine
// by Joanne

using System;

class HelloUser{
	
	static void Main()
	{
		string name;
		
		Console.WriteLine("What is your name?");

		name = Console.ReadLine();		

		Console.WriteLine("Hello, "+name+"!");

		Console.ReadKey();
	}
 }
 