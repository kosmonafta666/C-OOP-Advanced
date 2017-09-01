
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroGainsExperienceAfterAttackIfTargetDies()

    {
        Mock<ITarget> fakeTarget = new Mock<ITarget>();
        fakeTarget.Setup(p => p.Health).Returns(0);
        fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
        fakeTarget.Setup(p => p.IsDead()).Returns(true);

        Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
        fakeWeapon.Setup(x => x.AttackPoints).Returns(20);
        fakeWeapon.Setup(x => x.DurabilityPoints).Returns(20);

        Hero hero = new Hero("Pesho", fakeWeapon.Object);

        hero.Attack(fakeTarget.Object);

        Assert.AreEqual(20, hero.Experience);

    }
}

