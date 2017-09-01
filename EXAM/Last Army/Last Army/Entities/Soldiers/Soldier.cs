﻿using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private string name;
    private int age;
    private double experience;
    private double endurance;
    private double overallSkill;
    private IDictionary<string, IAmmunition> weapons;

    public Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
    }

    public string Name
    {
        get { return this.name; }
        set {this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public double Experience
    {
        get { return this.experience; }
        set { this.experience = value; }
    }

    public double Endurance
    {
        get { return this.endurance; }
        set { this.endurance = value; }
    }

    public double OverallSkill
    {
        get { return this.overallSkill; }
        set { this.overallSkill = value; }
    }

    public IDictionary<string, IAmmunition> Weapons
    {
        get { return this.weapons; }
        set { this.weapons = value; }
    }
    
    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    public void Regenerate()
    {

    }

    public void CompleteMission(IMission mission)
    {

    }

    private void AmmunitionRevision(double missionWearLevelDecrement)
    {
        IEnumerable<string> keys = this.Weapons.Keys.ToList();
        foreach (string weaponName in keys)
        {
            this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

            if (this.Weapons[weaponName].WearLevel <= 0)
            {
                this.Weapons[weaponName] = null;
            }
        }
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
}