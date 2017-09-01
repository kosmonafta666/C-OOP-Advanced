using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class SoldierFactory : ISoldierFactory
{
    public SoldierFactory()
    {
    }
    //name, age, experience, speed, endurance, motivation, maxWeight
    public static Soldier GenerateRanker(string name, int age, int experience, double endurance )
    {
        return new Ranker(name, age, experience, endurance);
    }

    public static Soldier GenerateCorporal(string name, int age, int experience,double endurance)
    {
        return new Corporal(name, age, experience,endurance);
    }

    public static Soldier GenerateSpecialForce(string name, int age, int experience, double endurance)
    {
        return new SpecialForce(name, age, experience, endurance);
    }

    public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
    {
        Type typeOfSoldier = Assembly.GetExecutingAssembly().GetType(soldierTypeName);

        var ctor = typeOfSoldier.GetConstructors().FirstOrDefault();

        var instance = ctor.Invoke(new object[] { name, age, experience, endurance });

        return (ISoldier)instance;
    }
}
