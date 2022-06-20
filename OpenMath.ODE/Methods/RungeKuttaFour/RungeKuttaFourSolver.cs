using OpenMath.ODE.Core;
using OpenMath.ODE.Discretizations;
using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Methods.RungeKuttaFour
{

    public class RungeKuttaFourSolver : SolverODE
    {
        public static RungeKuttaFourSolver Create() => new RungeKuttaFourSolver();
        public RungeKuttaFourSolver() { Setup(); }
        public RungeKuttaFourSolver Setup(DifferentialEquation[]? diffEquation = default, IMethodDiscretization? discretization = default)
        {
            if (diffEquation != default) { _equations = diffEquation; }
            if (discretization != default) { _discretizer = discretization; }
            return this;
        }


        private readonly RungeKuttaFourMethod _method = RungeKuttaFourMethod.Create();
        public override IMethodODE Method { get => _method; }

        private DifferentialEquation[] _equations = Array.Empty<DifferentialEquation>();
        public override DifferentialEquation[] Equations { get => _equations; set => _equations = value; }

        private IMethodDiscretization _discretizer = DiscretizationStep.Create();
        public override IMethodDiscretization Discretizer { get => _discretizer; set => _discretizer = value; }


        public override IResultODE Solve(double[] initialCond, double initial, double final)
        {
            return new RungeKuttaFourResult(base.Solve(initialCond, initial, final));
        }

    }
}
