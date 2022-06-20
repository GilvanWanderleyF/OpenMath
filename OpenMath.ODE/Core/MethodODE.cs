using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Core
{
    public abstract class MethodODE : IMethodODE
    {
        public abstract double[,] Solve(DifferentialEquation[] funcs, double[] initialCond, double[] time);
    }
}
