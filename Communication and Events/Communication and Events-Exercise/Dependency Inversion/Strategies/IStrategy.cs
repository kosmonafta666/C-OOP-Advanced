﻿namespace Dependency_Inversion.Strategies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
