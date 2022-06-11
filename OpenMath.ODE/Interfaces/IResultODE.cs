namespace OpenMath.ODE.Interfaces
{
    public interface IResultODE
    {
        public List<List<double>> Result { get; }
        public List<double> Time { get; }
    }
}
