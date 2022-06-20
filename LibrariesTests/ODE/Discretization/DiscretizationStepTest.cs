using LibrariesTests.ODE.Cases.Core;
using LibrariesTests.ODE.Interfaces;
using NUnit.Framework;
using OpenMath.ODE.Discretizations;

namespace LibrariesTests.ODE.Discretization
{
    internal class DiscretizationStepTest : IMethodDiscretizationTest
    {

        public DiscretizationStepTest(CaseDiscretization testCase, double step, double tolerance = 1e-6)
        {
            Case = testCase;
            Discretizer = DiscretizationStep.Create().Setup(step);
            Tolerance = tolerance;
        }


        public double Tolerance { get; }
        public CaseDiscretization Case { get; }
        public DiscretizationStep Discretizer { get; }


        public void DefaultConstructor()
        {
            DiscretizationStep d = DiscretizationStep.Create(); 

            Assert.That(d, Is.Not.Null); 
            Assert.That(d.GetType(), Is.EqualTo(typeof(DiscretizationStep)));
            Assert.That(Math.Abs(d.Step - 0.01), Is.LessThanOrEqualTo(Tolerance));
        }

        public void DiscretizationMethod()
        {
            DiscretizationStep d = Discretizer;

            double[] t = Discretizer.Discretization(Case.Initial, Case.Final);
            Assert.That(t[0], Is.EqualTo(Case.Initial));
            Assert.That(t[^1], Is.EqualTo(Case.Final));

            for (int i = 1; i < t.Length-2; i++)
            {
                double step = t[i] - t[i - 1];
                Assert.That(Math.Abs(step - d.Step), Is.LessThanOrEqualTo(Tolerance));
            }
        }


    }
}
