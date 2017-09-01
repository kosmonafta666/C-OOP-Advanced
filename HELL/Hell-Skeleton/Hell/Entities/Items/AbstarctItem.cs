
using System;
using System.Text;

public abstract class AbstarctItem : IItem
{
    public string Name { get; }

    public int StrengthBonus { get; }

    public int AgilityBonus { get; }

    public int IntelligenceBonus { get; }

    public int HitPointsBonus { get; }

    public int DamageBonus { get; }

    public AbstarctItem(string name, int strenght, int agility, int intelligence, int hitPoints, int damage)
    {
        this.Name = name;
        this.StrengthBonus = strenght;
        this.AgilityBonus = agility;
        this.IntelligenceBonus = intelligence;
        this.HitPointsBonus = hitPoints;
        this.DamageBonus = damage;
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"###Item: {this.Name}");
        result.AppendLine($"###+{this.StrengthBonus} Strength");
        result.AppendLine($"###+{this.AgilityBonus} Agility");
        result.AppendLine($"###+{this.IntelligenceBonus} Intelligence");
        result.AppendLine($"###+{this.HitPointsBonus} HitPoints");
        result.AppendLine($"###+{this.DamageBonus} Damage");

        return result.ToString().Trim();
    }
}

