using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrariesTests.ODE.Cases.Core
{
    internal abstract class CaseDiscretization
    {
        public abstract double Initial { get; }
        public abstract double Final { get; }
    }
}
