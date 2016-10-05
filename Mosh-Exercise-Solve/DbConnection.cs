using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {
            this.ConnectionString = connection;
        }

        public abstract void ConnectionOpen();
        public abstract void ConnectionClose();
    }
   
}
