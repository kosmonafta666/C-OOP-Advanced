
using System;
using System.Collections.Generic;

public class RecipeCommand : Command
{
    public RecipeCommand(IList<string> args, IManager manager) 
        : base(args, manager)
    {
    }

    public override string Execute()
    {
        return base.Manager.AddRecipeToHero(Args);
    }
}

