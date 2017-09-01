using System;
using System.Collections;
using System.Collections.Generic;

public interface ILeutenantGeneral : IPrivate
{
    IList<ISoldier> Soldiers { get; }
}

