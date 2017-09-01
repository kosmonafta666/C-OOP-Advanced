using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication_and_Events_Lab
{
    class Worker
    {
        public delegate void WorkPerformDelegate(int hours, WorkType type);

        public event EventHandler WorkComplete;

        public event WorkPerformDelegate WorkPerfomed;


        public Worker()
        {
            WorkPerfomed += OnWorkPerformed;
            WorkComplete += OnWorkComplete;
        }

        private void OnWorkComplete(object sender, EventArgs e)
        {
            WorkCompletedEventArgs args = e as WorkCompletedEventArgs;
            Console.WriteLine(args.WorkType + " " + args.Hours);
        }

        protected void OnWorkPerformed(int hours, WorkType type)
        {
            Console.WriteLine($"Wokk perfomed + {hours} hours");
        }

        public void DoWork(int hours, WorkType type)
        {
            //WorkPerfomed.Invoke(hours, type);
            WorkComplete.Invoke(this, new WorkCompletedEventArgs
            {
                Hours = hours,
                WorkType = type
            });
        }

    }
}
