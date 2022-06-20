using LibrariesTests.ODE.Cases.Core;
using LibrariesTests.ODE.Interfaces;
using NUnit.Framework;
using OpenMath.ODE.Discretizations;

namespace LibrariesTests.ODE.Discretization
{
    internal class DiscretizationPointsTest : IMethodDiscretizationTest
    {
        public DiscretizationPointsTest(CaseDiscretization testCase, int numPoints, double tolerance = 1e-6)
        {
            Case = testCase;
            Discretizer = DiscretizationPoints.Create().Setup(numPoints);
            Tolerance = tolerance;
        }

        public double Tolerance { get; }
        public CaseDiscretization Case { get; }
        public DiscretizationPoints Discretizer { get; }

        public void DefaultConstructor()
        {
            DiscretizationPoints d = DiscretizationPoints.Create();

            Assert.That(d, Is.Not.Null);
            Assert.That(d.GetType(), Is.EqualTo(typeof(DiscretizationPoints)));
            Assert.That(Math.Abs(d.NumPoints - 10), Is.LessThanOrEqualTo(Tolerance));
        }

        public void DiscretizationMethod()
        {
            DiscretizationPoints d = Discretizer;

            double[] t = Discretizer.Discretization(Case.Initial, Case.Final);
            Assert.That(t[0], Is.EqualTo(Case.Initial));
            Assert.That(t[^1], Is.EqualTo(Case.Final));
            Assert.That(Math.Abs(d.NumPoints - t.Length), Is.LessThanOrEqualTo(Tolerance));

        }
    }
}
