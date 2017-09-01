
using System;
using System.Collections.Generic;

public class HeroCommand : Command
{
    public HeroCommand(IList<string> args, IManager manager) 
        : base(args, manager)
    {
    }

    public override string Execute()
    {
        return base.Manager.AddHero(Args);
    }
}

