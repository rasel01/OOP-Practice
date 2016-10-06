using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public class SqlConnection:DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }

        public override void ConnectionOpen()
        {
            Console.WriteLine("SQL connection is open" );
        }
        
        public override void ConnectionClose()
        {
            Console.WriteLine("SQL connection is close");

        }
    }
}
