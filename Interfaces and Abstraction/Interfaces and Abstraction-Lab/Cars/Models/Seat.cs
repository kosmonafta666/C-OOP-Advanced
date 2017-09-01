using System;

public class Seat : ICar
{
    private string model;
    private string color;

    public string Model
    {
        get { return this.model; }
        private set
        {
            this.model = value;
        }
    }

    public string Color
    {
        get { return this.color; }
        private set
        {
            this.color = value;
        }
    }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.color = color;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaak!";
    }

    public override string ToString()
    {
        return $"{this.Model} Seat {this.Color}";
    }
}

