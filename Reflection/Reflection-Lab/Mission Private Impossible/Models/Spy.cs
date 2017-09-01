using System;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);

        StringBuilder result = new StringBuilder();

        MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance
            | BindingFlags.NonPublic);

        result.AppendLine($"All Private Methods of Class: {className}");
        result.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in privateMethods)
        {
            result.AppendLine(method.Name);
        }
 
        return result.ToString().Trim();
    }
}

