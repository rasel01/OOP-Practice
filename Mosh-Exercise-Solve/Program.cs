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
                //commit
                string start = sw.Start();
                Console.WriteLine("Start :" + start);
                Thread.Sleep(5000);
                string end = sw.Stop();
                Console.WriteLine("Stop :" + end);
                TimeSpan ts = (TimeSpan.Parse(end) - TimeSpan.Parse(start));
                Console.WriteLine("diffrence " + ts + Environment.NewLine);
            }
            

        }
    }
}
