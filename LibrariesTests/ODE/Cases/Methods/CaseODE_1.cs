using LibrariesTests.ODE.Cases.Core;
using OpenMath.ODE.Core;

namespace LibrariesTests.ODE.Cases.Methods
{
    internal class CaseODE_1 : CaseODE
    {
        public override DifferentialEquation[] Equations { get; } = new DifferentialEquation[]
        {
            (double t, double[] y) => y[1],
            (double t, double[] y) => 32 - 8*y[1]
        };

        public override double[] InitialCond { get; } = new double[] { 0.0, 0.0 };

        public override List<double> FuncValues(double t)
        {
            List<double> f = new List<double>()
            {
                4.0*(t + 0.125*Math.Exp(-8.0*t) - 0.125),
                4.0*(1.0 - Math.Exp(-8.0*t))
            };
            return f;
        }
    }
}
