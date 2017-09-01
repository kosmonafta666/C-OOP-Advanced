namespace Create_Custom_Class_Attribute.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string Author { get; private set; }

        public int Revision { get; private set; }

        public string Description { get; private set; }

        public string Reviewers { get; private set; }

        public CustomAttribute(string author, int revision, string description, string reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = reviewers;
        }
    }
}
