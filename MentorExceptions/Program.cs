using System;
using NLog;

namespace MentorExceptions
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter '#' when you want to exit");
            string inputString;
            do
            {
                inputString = Console.ReadLine();
                if (inputString == "#")
                    break;
                try
                {
                    Console.WriteLine(inputString[0]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    logger.Info("User has entered empty string");
                    Console.WriteLine("Empty string was entered");
                }
            }
            while (inputString != "#");
        }
    }
}
