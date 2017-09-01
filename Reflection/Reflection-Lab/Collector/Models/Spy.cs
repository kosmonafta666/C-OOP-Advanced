using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);

        StringBuilder result = new StringBuilder();

        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static
            | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (MethodInfo method in methods.Where(x => x.Name.StartsWith("get")))
        {
            result.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in methods.Where(x => x.Name.StartsWith("set")))
        {
            result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return result.ToString().Trim();
    }
}