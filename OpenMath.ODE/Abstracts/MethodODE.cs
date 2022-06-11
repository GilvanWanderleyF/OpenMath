using OpenMath.ODE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMath.ODE.Abstracts
{
    public abstract class MethodODE : IMethodODE
    {
        public abstract double[,] Solve(DiffEquation[] funcs, double[] initialCond, double[] time);
    }
}
