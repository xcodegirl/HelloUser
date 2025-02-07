# Hello User by Joanne #

## Welcome to my First C# Demo ##

Modified from console template. See also  https://aka.ms/new-console-template.

To create from template, use:

```
dotnet new console --use-program-main --output HelloUser
```


To compile, run csc command:

```
csc Program.cs /out:Hello.exe
```

To run, type:

```
Hello
```

Edit the code to main: 
```cs
 static void Main(string[] args)
 {
	Console.WriteLine("Enter your name.");
	string name = Console.ReadLine();		
	Console.WriteLine("Hello, "+name+"!");
```

Compile and run. Also, try running from Windows Explorer.

Add this code at the end of main to keep window open.

```cs
Console.WriteLine("Any key to exit.");		
Console.ReadKey();
```

Compile and run.

Edit the code again:

```cs
 static void Main(string[] args)
 {
	string name = args[0];
	Console.WriteLine("Hello, "+name+"!");
```

Compile and run with argument:

```
Hello Foo
```

Try run without argument. Fix the code to handle the error.

Now try reading in a list of names. Make a function to help.