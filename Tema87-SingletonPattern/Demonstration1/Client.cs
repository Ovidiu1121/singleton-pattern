using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.Demonstration1
{
    public class Client
    {
        public Client()
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            Console.WriteLine("Trying to make a captain for your team.");

            // Constructor is private. We cannot use "new" here.
            // Captain captain = new Captain(); // error
            Captain captain1 = Captain.GetCaptain();
            Console.WriteLine("Trying to make another captain for your team:");
            Captain captain2 = Captain.GetCaptain();

            if (captain1 == captain2)
            {
                Console.WriteLine("Both captain1 and captain2 are the same.");
            }
            Captain.CaptainDerived derived1 = captain1.NewCaptainDerived();
            Captain.CaptainDerived derived2 = captain1.NewCaptainDerived();
        }

    }
}
