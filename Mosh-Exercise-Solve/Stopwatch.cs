using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public class Stopwatch
    {
        public string start()
        {
            string start = DateTime.Now.ToString("HH:mm:ss ");
            return start;
        }

        public string stop()
        {
            string stop = DateTime.Now.ToString("HH:mm:ss ");
            return stop;
        }
    }
}
