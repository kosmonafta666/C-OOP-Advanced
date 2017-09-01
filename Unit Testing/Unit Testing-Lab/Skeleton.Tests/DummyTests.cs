
using NUnit.Framework;
using System;

[TestFixture]
class DummyTests
{
    private const int DummyHealth = 20;
    private const int DummyExperience = 20;
    private const string HeroName = "Ivan";

    public Dummy dummy;
    public Hero hero;

    [SetUp]
    public void TestUnit()
    {
        //Arange;
        this.dummy = new Dummy(DummyHealth, DummyExperience);
        this.hero = new Hero(HeroName, new Axe(10,10));
    }

    [Test]
    public void DummyHealtAfterAttack()
    {
        //Act
        this.dummy.TakeAttack(10);

        //Assert;
        Assert.AreEqual(10, this.dummy.Health);
    }

    [Test]
    public void DummyDeadAfterAttack()
    {
        //Act
        this.dummy.TakeAttack(25);

        //Assert;
        var ex = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(15));
        Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DummyDeadGiveExperience()
    {
        //Arrange
        this.dummy = new Dummy(10, 10);

        //Act
        this.hero.Attack(dummy);

        //Assert;
        Assert.AreEqual(10, this.hero.Experience);
    }

    [Test]
    public void DummyAliveCantGiveExperience()
    {
        //Act
        this.hero.Attack(dummy);

        //Assert;
        Assert.AreEqual(0, this.hero.Experience);
    }
}

