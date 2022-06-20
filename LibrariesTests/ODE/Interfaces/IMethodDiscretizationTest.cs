using LibrariesTests.ODE.Cases.Core;

namespace LibrariesTests.ODE.Interfaces
{
    internal interface IMethodDiscretizationTest
    {
        public double Tolerance { get; }
        public CaseDiscretization Case { get; }

        public void DefaultConstructor();
        public void DiscretizationMethod();
    }
}
