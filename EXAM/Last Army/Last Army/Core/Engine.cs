
using System;
using System.Text;

public class Engine : IEngine
{

    private IReader reader;
    private IWriter writer;
    private IGameController gameController;

    public Engine(IReader reader, IWriter writer, IGameController controller)
    {
        this.reader = reader;
        this.writer = writer;
        this.gameController = controller;
    }

    public void Run()
    {
        var result = new StringBuilder();

        var input = this.reader.ReadLine();

        while (!this.reader.Equals("Enough! Pull back!"))
        {
            try
            {
                this.gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }

            input = reader.ReadLine();
        }

        gameController.RequestResult(result);
        writer.WriteLine(result.ToString());
    }
}

