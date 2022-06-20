using OpenMath.ODE.Core;

namespace OpenMath.ODE.Interfaces
{
    public interface IMethodODE
    {
        public double[,] Solve(DifferentialEquation[] funcs, double[] initialCond, double[] time);
    }
}
