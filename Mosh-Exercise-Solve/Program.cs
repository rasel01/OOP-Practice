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
            // task : find differece between end time and start time
            //Stopwatch sw = new Stopwatch();
            //while (true)
            //{
            //    string start = sw.start();
            //    Console.WriteLine("start :" + start);
            //    Thread.Sleep(5000);
            //    string end = sw.stop();
            //    Console.WriteLine("stop :" + end);
            //    TimeSpan ts = (TimeSpan.Parse(end) - TimeSpan.Parse(start));
            //    Console.WriteLine("diffrence " + ts + Environment.NewLine);



            //}

            // task : exception occur when to stat called twice in a row


            //Post p = new Post();
            //int vote = 0;
            //Console.WriteLine(p.UploadPost());
            ////p.UploadPost();
            //bool count = true;
            //    while (count)
            //    {

            //        Console.WriteLine("Like This Post?" + " y or n ");
            //        string input = Console.ReadLine();
            //        switch (input)
            //        {
            //            case "y":
            //                vote = p.UpVote(vote);
            //                break;

            //            case "n":
            //                vote = p.DownVote(vote);
            //                break;
            //            default:
            //                vote = 0;
            //                break;

            //        }
            //        Console.WriteLine("want to vote more ?  y/n" + Environment.NewLine);
            //        var readLine = Console.ReadLine();
            //        if (readLine != null && readLine.Equals("n"))
            //        {
            //            count = false;
            //        }

                
            //    }
                
                
            //    Thread.Sleep(1000);

            //    Console.WriteLine("Your post get " + vote + " vote ");


            //DbConnection db1 = new SqlConnection("Hello");
            //db1.ConnectionString = "this is connetion string";
            //db1.ConnectionOpen();

            //DbConnection db2 = new OracleConnection("Hello");
            //db2.ConnectionString = "this is connetion string";
            //db2.ConnectionOpen();

            DbCommand command = new DbCommand("Insert into table 1");
            command.Execute();
                
            
                Console.ReadKey();


        }
    }
}
