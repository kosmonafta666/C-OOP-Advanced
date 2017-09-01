
using Event_Implementation;
using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        //create dispatcher;
        var dispatcher = new Dispatcher();
        //create handler;
        var handler = new Handler();
        //atach event to handler delegate;
        dispatcher.NameChange += handler.OnDispatcherNameChange;

        //read the names;
        string name;

        while ((name = Console.ReadLine()) != "End")
        {
            dispatcher.Name = name;
        }//end of while loop;
    }
}

