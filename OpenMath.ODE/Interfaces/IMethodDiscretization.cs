namespace OpenMath.ODE.Interfaces
{
    public interface IMethodDiscretization
    {
        public double[] Discretization(double initial, double final);
    }
}
