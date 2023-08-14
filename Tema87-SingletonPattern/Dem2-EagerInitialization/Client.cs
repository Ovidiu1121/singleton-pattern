using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.Dem2_EagerInitialization
{
    public class Client
    {
        public Client()
        {
            Console.WriteLine("***Singleton Pattern Demo using Eager Initialization***\n");
            Captain.dummyMethod();
            // Remaining code is omitted
        }
    }
}
