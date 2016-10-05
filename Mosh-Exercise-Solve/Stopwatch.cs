using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    public class Stopwatch
    {
        ///commit
        public string Start()
        {
            string start = DateTime.Now.ToString("HH:mm:ss ");
            return start;
        }

        public string Stop()
        {
            string stop = DateTime.Now.ToString("HH:mm:ss ");
            return stop;
        }
    }
}
