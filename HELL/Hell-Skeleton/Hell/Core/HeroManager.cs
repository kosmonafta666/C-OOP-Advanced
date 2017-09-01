using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager : IManager
{
    public Dictionary<string, IHero> heroes;

    public HeroManager()
    {
        this.heroes = new Dictionary<string, IHero>();
    }

    public string AddHero(IList<string> arguments)
    {
        string result = null;

        string heroName = arguments[0];
        string heroType = arguments[1];

        try
        {
            Type typeHero = Type.GetType(heroType);
            var constructors = typeHero.GetConstructors();
            IHero hero = (IHero)constructors[0].Invoke(new object[] {heroName});
            this.heroes.Add(hero.Name, hero);

            result = string.Format($"Created {heroType} - {hero.Name}");
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return result;
    }

    public string AddItemToHero(IList<string> arguments)
    {
        string result = null;

        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        CommonItem newItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus);
        
        this.heroes[heroName].AddItem(newItem);

        result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);
        return result;
    }
 

    public string AddRecipeToHero(IList<string> arguments)
    {
        string result = null;

        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);
        List<string> requiredItems = arguments.Skip(7).ToList();

        IRecipe newRecipe = new RecipeItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus, requiredItems);
        this.heroes[heroName].AddRecipe(newRecipe);

        result = string.Format(Constants.RecipeCreatedMessage, newRecipe.Name, heroName);
        return result;
    }

    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];

        return this.heroes[heroName].ToString();
    }

    public string Quit(object argList)
    {
        int counter = 1;
        var orderedHero = this.heroes
            .OrderByDescending(x => x.Value.PrimaryStats)
            .ThenByDescending(x => x.Value.SecondaryStats);

        var result = new StringBuilder();

        foreach (var hero in orderedHero)
        {
            result.AppendLine($"{counter++}. {hero.Value.GetType().Name}: {hero.Value.Name}");
            result.AppendLine($"###HitPoints: {hero.Value.HitPoints}");
            result.AppendLine($"###Damage: {hero.Value.Damage}");
            result.AppendLine($"###Strength: {hero.Value.Strength}");
            result.AppendLine($"###Agility: {hero.Value.Agility}");
            result.AppendLine($"###Intelligence: {hero.Value.Intelligence}");

            if (hero.Value.Items.Count == 0)
            {
                result.AppendLine($"###Items: None");
            }
            else
            {
                result.Append($"###Items: ");

                var itemsName = hero.Value.Items.Select(x => x.Name).ToList();

                result.AppendLine(string.Join(", ", itemsName));
            }
        }
        
        return result.ToString().Trim();
    }

    private string CreateGame()
    {
        StringBuilder result = new StringBuilder();

        foreach (var hero in heroes)
        {
            result.AppendLine(hero.Key);
        }

        return result.ToString();
    }

    /*
    //Само Батман знае как работи това
    public static void GenerateResult()
    {
        const string PropName = "_connectionString";

        var type = typeof(HeroCommand);

        FieldInfo fieldInfo = null;
        PropertyInfo propertyInfo = null;
        while (fieldInfo == null && propertyInfo == null && type != null)
        {
            fieldInfo = type.GetField(PropName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                propertyInfo = type.GetProperty(PropName,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            }

            type = type.BaseType;
        }
    }

    public static void DontTouchThisMethod()
    {
        //това не трябва да го пипаме, че ако го махнем ще ни счупи цялата логика
        var l = new List<string>();
        var m = new Manager();
        HeroCommand cmd = new HeroCommand(l, m);
        var str = "Execute";
        Console.WriteLine(str);
    }*/
}