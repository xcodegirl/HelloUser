// HelloUser main program
// by Joanne
using System;

namespace HelloUser;

// a class to hold helper functions
public class Functions
{
	public static int count = 0;
	public static void PrintUser(string name)
	{
		++ count; // increment counter
		
		// format & write message to console
		Console.WriteLine("Hello, "+name+"!");
	}
}

class Program
{	
    static void Main(string[] args)
    {
		string name;  // holds the user name

		if(args.Length > 0)
        {
			foreach (var arg in args)
			{	
				name = arg;
				Functions.PrintUser(name);
			}
			Console.WriteLine("Counted " + Functions.count + " names.");

		}else{

			// wait for user to enter name
			Console.WriteLine("Enter your name.");
			name = Console.ReadLine();		

			Functions.PrintUser(name);
		}

		// keep window open
		Console.WriteLine("Any key to exit.");		
		Console.ReadKey();
	}
 }
 