using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(new ThreadStart(Work));
            mythread.Start();

            Console.ReadLine();
        }

        private static void Work()
        {
            //throw new NotImplementedException();
            Thread.Sleep(3000);
            Console.WriteLine("Thread complete. ")
        }
    }
}
