namespace Work_Force
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JobList : List<Job>
    {
        public void OnJobDone(object sender, JobEventArgs e)
        {
            this.Remove(e.Job);
        }
    }
}
