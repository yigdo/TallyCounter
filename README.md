# Tally Counter

Tally Counter is just a project I made because I was feeling kinda bored. You can customize it and create your own TallyCounter.

### What is this project about?

If you want to pray a word by repeating it this project is for you. Basically you just need to create a ConsoleApplication in Visual Studio or you can just create it with the `dotnet sdk`

Run the command on terminal (dotnet sdk):
```bash
dotnet new console
```
This going to create you a basic .Net ConsoleApplication.

### Setup
Setup Guide for this project
#### Folder
Now that you created the Console Application it is time for the Actual Project.

I think that Nuget is not necessary for this project since it is only made up of one file. You can just install `TallyCounter.cs` in your computer and move on.

Now your folder structure should look similar to  this:

<ul>
  <li>
	Project Folder
	<ul>
	    <li>
	        ProjectName.csproj
	     </li>
	     <li>
	     TallyCounter.cs
	     </li>
	     <li>
	     Program.cs
	     </li>
   </ul>
 </li>
</ul>

Right!

#### The Code

Open Your `Program.cs` and write
````csharp
namespace <YourNamespace>
{
	class Program
	{
	  static void Main(string[] args)
	  {
	    TallyCounter TC = new TallyCounter;
	  
        Console.ReadKey();
	  }
	}
}
````
And also in the `TallyCounter.cs` File
````csharp
namespace <YourNamespace>
{
...
}
````
**DON'T FORGET TO WRITE YOUR NAMESPACE.**

Run the project and Ka-Boom 🤯! You Are Ready!

(c) Yigit Gulay 2022
