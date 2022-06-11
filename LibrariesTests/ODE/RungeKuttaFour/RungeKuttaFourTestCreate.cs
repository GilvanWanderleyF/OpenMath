using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenMath.ODE;
using OpenMath.ODE.Discretization;
using OpenMath.ODE.Interfaces;
using OpenMath.ODE.Methods.RungeKuttaFour;

namespace LibrariesTests.ODE.RungeKuttaFour
{
    [Category("Runge-Kutta-Four Test")]
    public class RungeKuttaFourTestCreate
    {
        //RungeKuttaFourTestCreate
        private DiffEquation[] equations;
        double[] initialCond;
        private ISolverODE ODE;
        private IResultODE result;

        [Test]
        public void Default()
        {
            ODE = RungeKuttaFourSolver.Create();

            
            Assert.IsNotNull(ODE);
            Assert.That(ODE.GetType(), Is.EqualTo(typeof(RungeKuttaFourSolver)));

            Assert.IsNotNull(ODE.Equations);
            Assert.That(ODE.Equations, Is.EqualTo(Array.Empty<DiffEquation>()));

            Assert.IsNotNull(ODE.Method);
            Assert.That(ODE.Method.GetType(), Is.EqualTo(typeof(RungeKuttaFourMethod)));

            Assert.IsNotNull(ODE.Discretizer);
            Assert.That(ODE.Discretizer.GetType(), Is.EqualTo(typeof(DiscretizationStep)));
        }

    }
}
