using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.Dem2_EagerInitialization
{
    public class Captain
    {
        // Early initialization
        private static readonly Captain CAPTAIN_INSTANCE = new Captain();

        // Making the constructor private
        // to prevent the use of "new"
        private Captain()
        {
            Console.WriteLine("\tNew captain is elected for your team.");
        }

        // Global point of access.
        public static Captain GetCaptain()
        {
            Console.WriteLine("\tYou already have a captain for your team.");
            Console.WriteLine("\tSend him for the toss.");
            return CAPTAIN_INSTANCE;
        }
        public static void dummyMethod()
        {
            Console.WriteLine("It is a dummy method");
        }
    }
}
