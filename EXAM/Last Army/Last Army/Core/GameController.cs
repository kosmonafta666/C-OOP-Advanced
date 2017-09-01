
using System;
using System.Collections.Generic;
using System.Text;

public class GameController : IGameController
    {
        private Dictionary<string, List<Soldier>> army;
        private Dictionary<string, List<IAmmunition>> wearHouse;
        private MissionController missionControllerField;

        public GameController()
        {
            this.Army = new Dictionary<string, List<Soldier>>();
            this.WearHouse = new Dictionary<string, List<IAmmunition>>();
            this.MissionControllerField = new MissionController(new Army(), new WareHouse());
        }

        public Dictionary<string, List<Soldier>> Army
        {
            get { return army; }
            set { army = value; }
        }

        public Dictionary<string, List<IAmmunition>> WearHouse
        {
            get { return wearHouse; }
            set { wearHouse = value; }
        }

        public MissionController MissionControllerField
        {
            get { return missionControllerField; }
            set { missionControllerField = value; }
        }

        public void GiveInputToGameController(string input)
        {
            var data = input.Split();

            if (data[0].Equals("Soldier"))
            {
                string type = string.Empty;
                string name = string.Empty;
                int age = 0;
                int experience = 0;
                double speed = 0d;
                double endurance = 0d;
                double motivation = 0;
                double maxWeight = 0d;

                if (data.Length == 3)
                {
                    type = data[1];
                    name = data[2];
                }
                else
                {
                    type = data[1];
                    name = data[2];
                    age = int.Parse(data[3]);
                    experience = int.Parse(data[4]);
                    endurance = double.Parse(data[5]);
                }

                var soldierFactory = new SoldierFactory();

                var soldier = soldierFactory.CreateSoldier(type, name, age, experience, endurance);
               
                //AddSoldierToArmy(soldier, type);
            }
            else if (data[0].Equals("WareHouse"))
            {
                string name = data[1];
                int number = int.Parse(data[2]);
                var ammoFactory = new AmmunitionFactory();
                var ammo = ammoFactory.CreateAmmunition(name);
                AddAmmunitions(ammo);
                Console.WriteLine(ammo.Weight);
            }
            else if (data[0].Equals("Mission"))
            {

            string type = data[1];
            double scopeToComplete = double.Parse(data[2]);
            var missionFactory = new MissionFactory();
            
            this.MissionControllerField.PerformMission(missionFactory.CreateMission(type, scopeToComplete));
            }
        }

        public string RequestResult(StringBuilder result)
        {
            return Output.GiveOutput(result, army, wearHouse, this.MissionControllerField.Missions.Count);
        }

        private void AddAmmunitions(IAmmunition ammunition)
        {
            if (!this.WearHouse.ContainsKey(ammunition.Name))
            {
                this.WearHouse[ammunition.Name] = new List<IAmmunition>();
                this.WearHouse[ammunition.Name].Add(ammunition);
            }
            else
            {
                //this.WearHouse[ammunition.Name][0].Number += ammunition.Number;
                this.WearHouse[ammunition.Name].Add(ammunition);
            }
        }

        private void AddSoldierToArmy(Soldier soldier, string type)
        {
            /*if (!soldier.CheckIfSoldierCanJoinTeam())
            {
                throw new ArgumentException($"The soldier {soldier.Name} is not skillful enough {type} team");
            }*/

            if (!this.Army.ContainsKey(type))
            {
                this.Army[type] = new List<Soldier>();
            }
            this.Army[type].Add(soldier);
        }
    }
