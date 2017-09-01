
using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private const int AxeAttack = 1;
    private const int AxeDurability = 1;
    private const int DummyHealth = 10;
    private const int DummyExperience = 10;

    public Axe sut;
    public Dummy dummy;

    [SetUp]
    public void TestInit()
    {
        //Arrange
        this.sut = new Axe(AxeAttack, AxeDurability);
        this.dummy = new Dummy(DummyHealth, DummyExperience);
    }

    [Test]
    public void AxeLosesDurabilityAfterAttack()
    {
        //Act
        this.sut.Attack(dummy);

        //Assert
        Assert.AreEqual(0, this.sut.DurabilityPoints, "Wrong");
    }

    [Test]
    public void BrokenAxeCantAttack()
    {    
        //Act
        this.sut.Attack(dummy);

        //Assert
        var ex = Assert.Throws<InvalidOperationException>(() => this.sut.Attack(dummy));
        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }
}

