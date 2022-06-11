namespace OpenMath.ODE.Interfaces
{
    public interface IMethodODE
    {
        public double[,] Solve(DiffEquation[] funcs, double[] initialCond, double[] time);
    }
}
