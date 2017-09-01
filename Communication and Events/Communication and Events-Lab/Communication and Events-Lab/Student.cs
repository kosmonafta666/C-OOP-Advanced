using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication_and_Events_Lab
{
    public class Student
    {
        public string Name { get; set; }

        public void AttendClass(Teacher teacher)
        {
            teacher.startTalking += StartTalking;
        }

        private void StartTalking(object sender, EventArgs e)
        {
            var teacherName = ((Teacher)sender).Name;

            Console.WriteLine($"{this.Name} listening to {teacherName}");
        }
    }
}
