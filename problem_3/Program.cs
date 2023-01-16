using System;
using System.Collections.Generic;

namespace problem_3
{
    public class Program
    {
        public static void Main()
        {
            var calculator = new PrimitiveCalculator(new AdditionStrategy());

            var input = Console.ReadLine().Split();

            while (!input[0].Equals("End") || !input[0].Equals("END") || !input[0].Equals("end"))
            {
                if (input[0].Equals("mode") || input[0].Equals("Mode") || input[0].Equals("MODE"))
                {
                    calculator.ChangeStrategy(char.Parse(input[1]));
                }
                else
                {
                    var firstNum = int.Parse(input[0]);
                    var secondNum = int.Parse(input[1]);

                    Console.WriteLine(calculator.PerformCalculation(firstNum, secondNum));
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}