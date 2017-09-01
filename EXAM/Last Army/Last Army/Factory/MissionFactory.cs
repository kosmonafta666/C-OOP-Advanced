
using System;
using System.Linq;
using System.Reflection;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        Type typeOfMission = Assembly.GetExecutingAssembly().GetType(difficultyLevel);

        var ctor = typeOfMission.GetConstructors().FirstOrDefault();

        var instance = ctor.Invoke(new object[] { neededPoints });

        return (IMission)instance;        
    }
}

