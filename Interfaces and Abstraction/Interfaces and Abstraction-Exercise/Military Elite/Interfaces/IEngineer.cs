using Military_Elite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public interface IEngineer : ISpecialisedSoldier
{
    IList<IRepair> Parts { get; }
}
