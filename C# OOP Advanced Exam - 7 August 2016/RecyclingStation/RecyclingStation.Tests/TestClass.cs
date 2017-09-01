using NUnit.Framework;
using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.BussinesLogic.Strategies;
using System;
using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using RecyclingStation.BussinesLogic.Attributes;

[TestFixture]
public class StrategyHolderTests
{
    private IGarbageDisposalStrategy ds;
    private IStrategyHolder sut;
    private Dictionary<Type, IGarbageDisposalStrategy> strategies;


    [SetUp]
    public void TestInit()
    {
        ds = new BurnableGarbageDisposalStrategy();
        strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        sut = new StrategyHolder(strategies);
    }

    [Test]
    public void TestPropertyForReadOnlyCollection()
    {
        //Arrange
        Type type = typeof(BurnableStrategyAttribute);

        //Act
        var sutProp = this.sut.GetType().GetProperty("GetDisposalStrategies");

        //Assert
        Assert.IsTrue(sutProp.SetMethod == null);
    }

    [Test]
    public void AddingStrategy()
    {
        //Arrange
        Type type = typeof(BurnableStrategyAttribute);
       
        //Act
        var addStrategy = this.sut.AddStrategy(type, this.ds);
        sut.AddStrategy(type, this.ds);

        //Assert
        Assert.IsTrue(addStrategy == true && this.sut.GetDisposalStrategies.Count == 1);
    }

    [Test]
    public void RemoveStrategy()
    {
        //Arrange
        Type type = typeof(BurnableStrategyAttribute);
      
        //Act
        this.sut.AddStrategy(type, this.ds);
        var RemoveStrategy = this.sut.RemoveStrategy(type);
        
        //Assert
        Assert.IsTrue(RemoveStrategy == true && this.sut.GetDisposalStrategies.Count == 0);
    }

    [Test]
    public void RemoveStrategyWithTwoStrategies()
    {
        //Arrange
        IGarbageDisposalStrategy ds1 = new StorableGarbageDisposalStrategy();
        Type type = typeof(BurnableStrategyAttribute);
        Type type1 = typeof(StorableStrategyAttribute);
      
        //Act
        this.sut.AddStrategy(type, this.ds);
        this.sut.AddStrategy(type1, ds1);
        var RemoveStrategy = this.sut.RemoveStrategy(type);

        //Assert
        Assert.IsTrue(RemoveStrategy == true && this.sut.GetDisposalStrategies.Count == 1);
    }
}

