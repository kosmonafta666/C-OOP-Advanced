using System;
using System.Text;
using System.Reflection;
using System.Linq;

public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        StringBuilder result = new StringBuilder();

        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
            | BindingFlags.Public);

        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance
            | BindingFlags.NonPublic);

        foreach (FieldInfo field in classFields)
        {
            result.AppendLine($"{field.Name} must be private!");
        }

        foreach (MethodInfo method in classNonPublicMethods.Where(x => x.Name.StartsWith("get")) )
        {
            result.AppendLine($"{method.Name} have to be public!");
        }

        foreach ( MethodInfo method in classPublicMethods.Where(x => x.Name.StartsWith("set")) )
        {
            result.AppendLine($"{method.Name} have to be private!");
        }

        return result.ToString().Trim();
    }
}

