﻿namespace Card_Power.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        private string type;

        public string Type => this.type;

        public string Category { get; set; }

        public string Description { get; set; }

        public TypeAttribute(string category, string description)
        {
            this.type = "Enumeration";
            this.Category = category;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
