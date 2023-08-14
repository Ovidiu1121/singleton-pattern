using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.Demonstration1
{
    class Captain
    {
        private static Captain captain;
        static int numberOfInstance = 0;
        private static readonly object captainLock = new object();

        // Making the constructor private
        // to prevent the use of "new"
        private Captain()
        {
            numberOfInstance++;
            Console.WriteLine("Number of instances at this moment=" + numberOfInstance);
        }

        public static Captain GetCaptain()
        {
            lock (captainLock)
            {
                // Lazy initialization
                if (captain == null)
                {
                    captain = new Captain();
                    Console.WriteLine("\tA new captain is elected for your team.");
                }
                else
                {
                    Console.WriteLine("\tYou already have a captain for your team.");
                    Console.WriteLine("\tSend him for the toss.");
                }

                return captain;
            }
        }

        // A non-static nested class (inner class)
        public class CaptainDerived : Captain
        {
            // Some code
        }
        public CaptainDerived NewCaptainDerived()
        {
            return new CaptainDerived();
        }
    }
}
