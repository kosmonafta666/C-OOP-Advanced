using System;
using System.Linq;

public class Smartfone : ICallable, IBrowsable
{
    public string Browse(string url)
    {
        bool isDigit = url.Any(char.IsDigit);

        if (isDigit)
        {
            return "Invalid URL!";
        }
        else
        {
            return $"Browsing: {url}!";
        }
    }

    public string Call(string number)
    {
        bool isLetter = number.Any(char.IsLetter);

        if (isLetter)
        {
            return "Invalid number!";
        }
        else
        {
            return $"Calling... {number}";
        }
    }
}

