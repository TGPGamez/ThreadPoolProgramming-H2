using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolProgramming_H2
{
    class Øvelse_1og2
    {
        public void Start()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution..");
            stopwatch.Start();
            ProcessWithThreadPoolMethod();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is: " + stopwatch.ElapsedTicks.ToString());
            stopwatch.Reset();
            Console.WriteLine("Thread Execution..");
            stopwatch.Start();
            ProcessWithThreadMethod();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is: " + stopwatch.ElapsedTicks.ToString());
        }

        private void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }

        private void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }


        private void Process(object callback)
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {

                }
            }
        }
    }
}
