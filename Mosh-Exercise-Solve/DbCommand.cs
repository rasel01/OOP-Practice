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

        public DbCommand(DbConnection conenction)
        {
            _db = conenction;
        }
        public DbCommand(DbConnection conenction, string command)
            : this(conenction)
        {

            Command = command;
        }

        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(Command))
            {
                Console.WriteLine("cmd exception");
                return;
            }
            _db.ConnectionOpen();
            Console.WriteLine(Command);
            _db.ConnectionClose();
        }
    }
}
