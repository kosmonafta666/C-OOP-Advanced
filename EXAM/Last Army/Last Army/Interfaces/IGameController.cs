
using System.Text;

public interface IGameController
{
    void GiveInputToGameController(string input);

    string RequestResult(StringBuilder result);
}

