using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class HeroInventoryTests
{
    private HeroInventory sut;

    [SetUp]
    public void TestInit()
    {
        this.sut = new HeroInventory();
    }

    [Test]
    public void AddCommonItem()
    {
        //Arrange
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddCommonItem(item);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .FirstOrDefault(f => f.GetCustomAttributes(typeof(ItemAttribute)) != null);
        var collection = (Dictionary<string, IItem>)field.GetValue(this.sut);

        //Assert
        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void AddMatchedCommonItemWithExistingRecipe()
    {
        //Arrange
        RecipeItem recipeItem = new RecipeItem("recipe1", 10, 2, 3, 4, 5, new List<string>() { "item" });
        CommonItem commonItem = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddRecipeItem(recipeItem);
        this.sut.AddCommonItem(commonItem);

        //Assert
        Assert.AreEqual(10, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AddTwoMatchedCommonItemWithExistingRecipe()
    {
        //Arrenge
        RecipeItem recipeItem = new RecipeItem("recipe1", 10, 2, 3, 4, 5, new List<string>() { "item1", "item2" });
        CommonItem commonItem1 = new CommonItem("item1", 1, 2, 3, 4, 5);
        CommonItem commonItem2 = new CommonItem("item2", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddRecipeItem(recipeItem);
        this.sut.AddCommonItem(commonItem1);
        this.sut.AddCommonItem(commonItem2);

        //Assert
        Assert.AreEqual(10, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AddNonMatchedCommonItemWithExistingRecipe()
    {
        //Arrange
        RecipeItem recipeItem = new RecipeItem("recipe1", 10, 2, 3, 4, 5, new List<string>() { "item" });
        CommonItem item = new CommonItem("item1", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddRecipeItem(recipeItem);
        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(1, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AddRecipeItem()
    {
        //Arrange
        RecipeItem item = new RecipeItem("item", 1, 2, 3, 4, 5, new List<string>());

        //Act
        this.sut.AddRecipeItem(item);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetField("recipeItems", BindingFlags.Instance | BindingFlags.NonPublic);

        var collection = (Dictionary<string, IRecipe>)field.GetValue(this.sut);

        //Assert
        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void StrengthBonusFromItems()
    {
        //Arrange
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(1, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AgilityBonusFromItems()
    {
        //Arrange
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddCommonItem(item);

        //Arrange
        Assert.AreEqual(2, this.sut.TotalAgilityBonus);
    }

    [Test]
    public void IntelligenceBonusFromItems()
    {
        //Arrange
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(3, this.sut.TotalIntelligenceBonus);
    }

    [Test]
    public void HitPointsBonusFromItems()
    {
        //Arrange
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(4, this.sut.TotalHitPointsBonus);
    }

    [Test]
    public void DamageBonusFromItems()
    {
        //Arrange
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        //Act
        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(5, this.sut.TotalDamageBonus);
    }

    [Test]
    public void CheckRecipeWithMatchedItem()
    {
        //Arrange
        CommonItem commonItem = new CommonItem("item", 1, 2, 3, 4, 5);
        RecipeItem recipeItem = new RecipeItem("recipe1", 10, 2, 3, 4, 5, new List<string>() { "item" });

        //Act
        this.sut.AddCommonItem(commonItem);
        this.sut.AddRecipeItem(recipeItem);

        //Assert
        Assert.AreEqual(10, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void CheckRecipeWithTwoMatchedItem()
    {
        //Arrange
        CommonItem commonItem1 = new CommonItem("item1", 1, 2, 3, 4, 5);
        CommonItem commonItem2 = new CommonItem("item2", 1, 2, 3, 4, 5);
        RecipeItem recipeItem = new RecipeItem("recipe1", 10, 2, 3, 4, 5, new List<string>() { "item1", "item2" });

        //Act
        this.sut.AddCommonItem(commonItem1);
        this.sut.AddCommonItem(commonItem2);
        this.sut.AddRecipeItem(recipeItem);

        //Assert
        Assert.AreEqual(10, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void CheckRecipeWithNoMatchedItem()
    {
        //Arrange
        CommonItem commonItem = new CommonItem("item", 1, 2, 3, 4, 5);
        RecipeItem recipeItem = new RecipeItem("recipe1", 10, 2, 3, 4, 5, new List<string>() { "item1" });

        //Act
        this.sut.AddCommonItem(commonItem);
        this.sut.AddRecipeItem(recipeItem);
    
        //Assert
        Assert.AreEqual(1, this.sut.TotalStrengthBonus);
    }
}

