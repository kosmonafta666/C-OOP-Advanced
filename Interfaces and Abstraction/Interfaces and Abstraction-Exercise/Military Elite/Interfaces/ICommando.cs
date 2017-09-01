using Military_Elite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICommando : ISpecialisedSoldier
{
    IList<IMission> Missions { get; }

    void CompleteMission();
}
