using System;
using System.Text;
using System.Reflection;
using System.Linq;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] reguestedFields)
    {
        Type classType = Type.GetType(investigatedClass);

        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
            | BindingFlags.NonPublic | BindingFlags.Public);

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        StringBuilder result = new StringBuilder();

        result.AppendLine($"Class under investigation: {investigatedClass}");

        foreach ( FieldInfo field in classFields.Where(x => reguestedFields.Contains(x.Name)) )
        {
            result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
       
        return result.ToString().Trim();
    }
}

