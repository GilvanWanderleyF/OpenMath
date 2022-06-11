using OpenMath.ODE.Entities;
using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Abstracts
{
    public abstract class SolverODE : ISolverODE
    {
        public abstract IMethodODE Method { get; }
        public abstract DiffEquation[] Equations { get; set; }
        public abstract IMethodDiscretization Discretizer { get; set; }

        public virtual IResultODE Solve(double[] initialCond, double initial, double final)
        {
            CheckODE.Dimension(Equations, initialCond);

            double[] time = Discretizer.Discretization(initial, final);
            return new ResultODE(time, Method.Solve(Equations, initialCond, time));
        }
    }
}
