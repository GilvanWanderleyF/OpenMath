using OpenMath.ODE.Entities;
using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Core
{
    public abstract class SolverODE : ISolverODE
    {
        public abstract IMethodODE Method { get; }
        public abstract DifferentialEquation[] Equations { get; set; }
        public abstract IMethodDiscretization Discretizer { get; set; }

        public virtual IResultODE Solve(double[] initialCond, double initial, double final)
        {
            ValidatorODE.ODE(Equations, initialCond);

            double[] time = Discretizer.Discretization(initial, final);
            return new ResultODE(time, Method.Solve(Equations, initialCond, time));
        }
    }
}
