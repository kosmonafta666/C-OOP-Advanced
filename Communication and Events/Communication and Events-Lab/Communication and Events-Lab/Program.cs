using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication_and_Events_Lab
{
    class Program
    {

        static void Main(string[] args)
        {
            var worker = new Worker();

            worker.DoWork(7, WorkType.fuckung);

            worker.WorkComplete += TT;

            TT(worker, new WorkCompletedEventArgs
            {
                Hours = 12,
                WorkType = WorkType.fuckung
            });

        }

        private static void TT(object sender, EventArgs e)
        {
            WorkCompletedEventArgs args = e as WorkCompletedEventArgs;
            Console.WriteLine(args.WorkType + " " + args.Hours);
        }

        private static void ppp(int hours, WorkType type)
        {
            Console.WriteLine(hours + type.ToString());
        }

        private static void WorkPerfomedSecondMethod(int hours, WorkType type)
        {
            Console.WriteLine($"{hours} + {type.ToString()}");
        }
    }
}
