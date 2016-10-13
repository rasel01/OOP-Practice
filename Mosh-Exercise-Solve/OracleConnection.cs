using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public class OracleConnection : DbConnection
    {
        public override void ConnectionOpen()
        {
            Console.WriteLine("Oracle connection is open");
        }

        public override void ConnectionClose()
        {
            Console.WriteLine("Oracle connection is close");
        }

        public OracleConnection(string connection) : base(connection)
        {
        }
    }
}
