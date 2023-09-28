using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture newScripture = new Scripture();

        Console.WriteLine(newScripture.WriteScripturesToConsole());
    }
}