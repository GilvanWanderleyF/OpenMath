using OpenMath.ODE.Abstracts;
using OpenMath.ODE.Discretization;
using OpenMath.ODE.Interfaces;
using OpenMath.ODE.Methods.RungeKuttaFour;

namespace OpenMath.ODE
{

    public class RungeKuttaFourSolver : SolverODE
    {        
        public static RungeKuttaFourSolver Create() => new RungeKuttaFourSolver();
        public RungeKuttaFourSolver() { Setup(); }
        public RungeKuttaFourSolver Setup(DiffEquation[]? diffEquation = default, IMethodDiscretization? discretization = default)
        {
            if (diffEquation != default) { _equations = diffEquation; }        
            if (discretization != default) { _discretizer = discretization; }

            return this;
        }
        
        
        private readonly RungeKuttaFourMethod _method = RungeKuttaFourMethod.Create();
        public override IMethodODE Method { get => _method; }

        private DiffEquation[] _equations = Array.Empty<DiffEquation>();
        public override DiffEquation[] Equations { get => _equations; set => _equations = value; }

        private IMethodDiscretization _discretizer = DiscretizationStep.Create();
        public override IMethodDiscretization Discretizer { get => _discretizer; set => _discretizer = value; }


        public override IResultODE Solve(double[] initialCond, double initial, double final)
        {
            return new RungeKuttaFourResult(base.Solve(initialCond, initial, final));
        }

    }
}
