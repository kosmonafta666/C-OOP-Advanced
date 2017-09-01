using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication_and_Events_Lab
{
    public class WorkCompletedEventArgs : EventArgs
    {
        public int Hours { get; set; }

        public WorkType WorkType { get; set; }
    }
}
