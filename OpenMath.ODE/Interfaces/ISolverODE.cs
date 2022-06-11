namespace OpenMath.ODE.Interfaces
{
    public interface ISolverODE
    {
        public IMethodODE Method { get;}
        public DiffEquation[] Equations { get; set; }
        public IMethodDiscretization Discretizer { get; set; }

        public IResultODE Solve(double[] initialCond, double initial, double final);
    }
}
