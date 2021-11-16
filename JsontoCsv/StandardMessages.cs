using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public static class StandardMessages
    {
        public static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program");
        }

        public static void ShowInvalidFileMessage()
        {
            Console.WriteLine("File does not exist");
            
        }
        public static void ShowEndMessage()
        {
            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
        public static void ShowInvalidArgumentMessage()
        {
            Console.WriteLine("Invalid argument given");
        }
        public static void ShowMissingArgumentMessage()
        {
            Console.WriteLine("Argument missing");
        }
    }
}
