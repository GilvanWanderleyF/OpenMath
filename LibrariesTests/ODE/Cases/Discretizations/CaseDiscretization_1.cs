using LibrariesTests.ODE.Cases.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrariesTests.ODE.Cases.Discretizations
{
    internal class CaseDiscretization_1 : CaseDiscretization
    {
        public override double Initial { get; } = 0.0;
        public override double Final { get; } = 10.0;

    }
}
