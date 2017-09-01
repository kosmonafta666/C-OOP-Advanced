
using System;
using System.Collections.Generic;

public class RecipeItem : AbstarctItem, IRecipe
{
    public IList<string> RequiredItems { get; }

    public RecipeItem(string name, int strenght, int agility, int intelligence, int hitPoints, int damage, IList<string> requiredItems) 
        : base(name, strenght, agility, intelligence, hitPoints, damage)
    {
        this.RequiredItems = requiredItems;
    }    
}

