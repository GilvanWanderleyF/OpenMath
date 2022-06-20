using LibrariesTests.ODE.Cases.Discretizations;
using LibrariesTests.ODE.Discretization;
using NUnit.Framework;

namespace LibrariesTests.ODE
{
    [Category("Discretization Test")]
    internal class DiscretizationTest
    {
        #region Tests of DiscretizationStep with the CaseDiscretization_1
        DiscretizationStepTest DiscretizationStep1 = new (new CaseDiscretization_1(), 0.1);
        [Test]
        public void DiscretizationStep1_DefaultConstructor() => DiscretizationStep1.DefaultConstructor();
        [Test]
        public void DiscretizationStep1_DiscretizationMethod() => DiscretizationStep1.DiscretizationMethod();
        #endregion

        #region Test of DiscretizationPoints with the CaseDiscretization_1
        DiscretizationPointsTest DiscretizationPoints1 = new (new CaseDiscretization_1(), 20);
        [Test]
        public void DiscretizationPoints1_DefaultConstructor() => DiscretizationPoints1.DefaultConstructor();
        [Test]
        public void DiscretizationPoints1_DiscretizationMethod() => DiscretizationPoints1.DiscretizationMethod();
        #endregion

    }
}
