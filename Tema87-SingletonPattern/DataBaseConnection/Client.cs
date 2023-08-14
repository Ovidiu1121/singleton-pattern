using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.DBConnection
{
    public class Client
    {

        public Client()
        {
            Console.WriteLine("Making a data base connection");

            DBConnection dBConnection = DBConnection.GetConnection();
            Console.WriteLine("Trying to make another connection");
            DBConnection dBConnection2 = DBConnection.GetConnection();



        }

    }
}
