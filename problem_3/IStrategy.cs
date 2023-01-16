using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
