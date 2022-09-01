using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Stopwatch
    {
       
        public static void Watch()

        {
            Stopwatch watch = new Stopwatch();

            var start = DateTime.Today;
            Console.WriteLine("start time:" + start);

            var end = DateTime.Today;
            Console.WriteLine("End Time:" + end);

            Console.WriteLine("Elapsed time:" + (end - start));
        }
    }
}
