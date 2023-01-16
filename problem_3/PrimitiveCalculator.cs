using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    public class PrimitiveCalculator
    {
        private readonly IDictionary<char, IStrategy> possibleStrategies = new Dictionary<char, IStrategy>
    {
        { '+', new AdditionStrategy() },
        { '-', new SubtractionStrategy() },
        { '*', new MultiplicationStrategy() },
        { '/', new DivisionStrategy() }
    };

        private IStrategy strategy;

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ChangeStrategy(char @operator)
        {
            this.strategy = this.possibleStrategies[@operator];
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }

        public class SubtractionStrategy : IStrategy
        {
            public int Calculate(int firstOperand, int secondOperand)
            {
                return firstOperand - secondOperand;
            }
        }
    }

}
