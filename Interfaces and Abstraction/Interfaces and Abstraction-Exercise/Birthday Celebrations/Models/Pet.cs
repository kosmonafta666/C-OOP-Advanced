using System;

public class Pet : IBirth
{
    private string name;
    private string birthDate;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string BirthDate
    {
        get { return this.birthDate; }
        set { this.birthDate = value; }
    }

    public Pet(string name, string birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }
}

