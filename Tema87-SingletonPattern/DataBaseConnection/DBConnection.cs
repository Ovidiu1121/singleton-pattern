using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema87_SingletonPattern.DBConnection
{
    public class DBConnection
    {

        private static DBConnection connection;
        private static readonly object connectionlock = new object();

        private DBConnection()
        {

        }

        public static DBConnection GetConnection()
        {
             lock (connectionlock)
            {
                if (connection == null)
                {
                    connection = new DBConnection();
                    Console.WriteLine("The data base connection has been created");
                }
                else
                {
                    Console.WriteLine("A data base connection already exist");
                }
                return connection;
            }
        }

    }
}
