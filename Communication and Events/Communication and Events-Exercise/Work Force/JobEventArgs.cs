namespace Work_Force
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JobEventArgs : EventArgs
    {
        public Job Job { get; set; }

        public JobEventArgs(Job job)
        {
            this.Job = job;
        }
    }
}
