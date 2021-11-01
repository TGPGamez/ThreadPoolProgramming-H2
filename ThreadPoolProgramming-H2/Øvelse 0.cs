using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolProgramming_H2
{
    class Øvelse_0
    {
        public void Start()
        {
            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(Task1);
                ThreadPool.QueueUserWorkItem(Task2);
            }
            Console.Read();
        }

        private void Task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        private void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }
    }
}
