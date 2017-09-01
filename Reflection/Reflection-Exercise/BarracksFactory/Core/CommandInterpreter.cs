namespace _03BarracksFactory.Core
{
    using System;
    using _03BarracksFactory.Contracts;
    using System.Reflection;
    using System.Globalization;
    using System.Linq;
    using _03BarracksFactory.Attributes;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandSuffix = "Command";

        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string commandCompleteName = CultureInfo
                .CurrentCulture
                .TextInfo
                .ToTitleCase(commandName) + CommandSuffix;
                
            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandCompleteName);

            object[] commandParams =
            {
                data
            };

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid Commnad!");
            }

            IExecutable currentCommand =  (IExecutable)Activator.CreateInstance(commandType, commandParams);

            currentCommand = this.InjectDependencies(currentCommand);

            return currentCommand;
        }

        private IExecutable InjectDependencies(IExecutable currentCommand)
        {
            FieldInfo[] fields = currentCommand.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.GetCustomAttributes<InjectAttribute>() != null)
                .ToArray();

            foreach (var field in fields)
            {
                if (field.FieldType == typeof(IRepository))
                {
                    field.SetValue(currentCommand, this.repository);
                }
                else if (field.FieldType == typeof(IUnitFactory))
                {
                    field.SetValue(currentCommand, this.unitFactory);
                }
            }

            return currentCommand;

        }
    }
}
