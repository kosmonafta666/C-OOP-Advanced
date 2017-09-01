namespace _03BarracksFactory.Core.Commands
{
    using System;
    using _03BarracksFactory.Contracts;
    using _03BarracksFactory.Attributes;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            this.repository.RemoveUnit(Data[1]);
            return $"{Data[1]} retired!";
        }
    }
}
