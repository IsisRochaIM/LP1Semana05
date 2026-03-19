using System;

namespace LevelOne
{

    /// <summary>
    /// The MainIsHere class contains the entry point of the application.
    /// </summary>

    public class MainIsHere
    {
        /// <summary>
        /// The main method is the entry point of a C# console application. When you run the application, the Main method is executed first. In this example, it simply prints "Hello LP!" to the console.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            Console.WriteLine("Bad day");
            Console.WriteLine(someMethod());
        }
        /// <summary>
        /// This method returns a string that can be printed to the console.
        /// </summary>
        /// <returns></returns>
        private static string someMethod()
        {
            return "This is a method that returns a string.";
        }
    }
}
