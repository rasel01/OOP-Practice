using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public class DbCommand
    {
        public string Command { get; set; }
        private readonly DbConnection _db;
        public DbCommand(string instruction)
        {
            _db = new OracleConnection("ConnectinString For SQl Database connection");
            Command = instruction;

        }

        public void Execute()
        {
            _db.ConnectionOpen();
            Console.WriteLine(Command);
            _db.ConnectionClose();
        }
    }
}
