using System;

namespace LevelOne
{
    /// <summary>
    /// The MainIsHere class contains the entry point of the application.
    /// </summary>
    public class MainIsHere
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            Console.WriteLine(someMethod());
        }
        private static string someMethod()
        {
            return "This is a method that returns a string.";
        }
    }
}
