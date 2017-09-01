namespace Dependency_Inversion
{
    using Dependency_Inversion.Strategies;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PrimitiveCalculator
    {
        private IStrategy strategy;
        private Dictionary<char, IStrategy> strategies = new Dictionary<char, IStrategy>()
        {
            {'+', new AdditionStrategy()},
            {'-', new SubtractionStrategy()},
            {'*', new MultiplyStrategy()},
            {'/', new DivideStrategy()},
        };

        public PrimitiveCalculator()
        {
            this.strategy = strategies['+'];
        }

        public void changeStrategy(char @operator)
        {
            this.strategy = strategies[@operator];
        }

        public int performCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
