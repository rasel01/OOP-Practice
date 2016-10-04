using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mosh_Exercise_Solve
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            while (true)
            {
                string start = sw.start();
                Console.WriteLine("start :" + start);
                Thread.Sleep(5000);
                string end = sw.stop();
                Console.WriteLine("stop :" + end);
                TimeSpan ts = (TimeSpan.Parse(end) - TimeSpan.Parse(start));
                Console.WriteLine("diffrence " + ts + Environment.NewLine);
            }
            

        }
    }
}
