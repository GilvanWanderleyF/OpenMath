using NUnit.Framework;
using OpenMath.ODE;
using OpenMath.ODE.Discretization;
using OpenMath.ODE.Interfaces;
using OpenMath.ODE.Methods;

namespace LibrariesTests
{
    [Category("Test_ODE")]
    public class TestODE
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Cria uma instânce da SolverODE class
            // Cria uma do método
            // Roda um caso

            DiffEquation[] equations = new DiffEquation[]
            {
                (double t, double[] y) => 1.0,
                (double t, double[] y) => 2.0
            };

            double[] initialCond = new double[] { 10.0, 0.0 };
            double intial = 0;
            double final = 5;

            ISolverODE ODE = RungeKuttaFourSolver.Create()
                .Setup(equations, 
                       DiscretizationStep.Create()
                        .Setup(0.1));

            IResultODE result = ODE.Solve(initialCond, intial, final);
            

            Assert.Pass();
        }
    }
}