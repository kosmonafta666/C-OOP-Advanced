

using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    public AmmunitionFactory()
    {
    }

    public IAmmunition CreateAmmunition(string name)
    {
        Type type = Assembly.GetExecutingAssembly().GetType(name);

        var ctor = type.GetConstructors().FirstOrDefault();

        var instance = ctor.Invoke(new object[] { name });
        
        return (IAmmunition)instance;
    }

    /*public static Ammunition CreateAmmunitions(string name, int number)
    {
        switch (name)
        {
            case "BulletproofVest":
                return new BulletproofVest(name, number);
            case "Grenades":
                return new Grenades(name, number);
            case "Helmet":
                return new Helmet(name, number);
            case "Knife":
                return new Knife(name, number);
            case "NightVision":
                return new NightVision(name, number);
            case "Shield":
                return new Shield(name, number);
            case "AutomaticMachine":
                return new AutomaticMachine(name, number);
            case "Gun":
                return new Gun(name, number);
            case "MachineGun":
                return new MachineGun(name, number);
        }
        //if none of the above did not match it will be RPG
        return new RPG(name, number);
    }*/
}
