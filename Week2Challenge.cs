using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week2Challenges
{
    [TestClass]
    public class Greeter
    {
    
        public string Name(string inputName)
        {
            string fullName = "Hello " + inputName;
            return fullName;
        }

        public string NameGoodbye(string inputname2)
        {
            string fullMessage = "Farewell " + inputname2;
            return fullMessage;
        }

        public void TimeOfDay()
        {
            Console.WriteLine("Please enter the time of day (morning, afternoon, evening, night");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "morning":
                    Console.WriteLine("Good morning!");
                    break;
                case "afternoon":
                    Console.WriteLine("Good afternoon!");
                    break;
                case "evening":
                    Console.WriteLine("Good evening!");
                    break;
                case "night":
                    Console.WriteLine("Good night!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }
        }

        [TestMethod]
        public void Main()
        {
            string fullName = Name("Jim");
            string goodBye = NameGoodbye("Steve");
            Console.WriteLine(fullName);
            Console.WriteLine(goodBye);
            TimeOfDay();


        }

    }
    
}
