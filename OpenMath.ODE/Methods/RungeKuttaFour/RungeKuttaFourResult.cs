using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Methods.RungeKuttaFour
{
    public class RungeKuttaFourResult : IResultODE
    {
        private readonly IResultODE _result;

        public RungeKuttaFourResult(IResultODE result)
        {
            _result = result;
        }

        public List<List<double>> Result => _result.Result;
        public List<double> Time => _result.Time;
    }
}
