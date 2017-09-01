namespace Collection_Hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICountable : IAddable, IRemovable
    {
        int Used { get; }
    }
}
