using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.Dem3_BillPughsSolution
{
    public class Captain
    {
        private Captain()
        {
            Console.WriteLine("\tNew captain is elected for your team.");
        }

        // The helper class
        private class SingletonHelper
        {
            // This nested class is referenced after
            // the GetCaptain() method is called.
            internal static readonly Captain CAPTAIN_INSTANCE = new Captain();
        }

        public static Captain GetCaptain()
        {
            return SingletonHelper.CAPTAIN_INSTANCE;
        }
    }
}
