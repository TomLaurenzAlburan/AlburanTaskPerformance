using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriorityy
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loop = 0; loop < 2; loop++)
            {
                Thread.Sleep(500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loop);
            }
        }


        public static void Thread2()
        {
            for (int loop = 0; loop < 6; loop++)
            {
                Thread.Sleep(1500); 
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loop);
            }
        }
    }
}