
using System;
using System.Collections.Generic;

public abstract class Command : ICommand
{
    public IList<string> Args { get; private set; }

    public IManager Manager { get; private set; }

    public Command(IList<string> args, IManager manager)
    {
        this.Args = args;
        this.Manager = manager;
    }

    public abstract string Execute();   
}

