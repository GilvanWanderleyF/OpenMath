using OpenMath.ODE.Core;
using OpenMath.ODE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrariesTests.ODE.Cases.Core
{
    internal abstract class CaseODE
    {
        public abstract DifferentialEquation[] Equations { get; }
        public abstract double[] InitialCond { get; }

        public abstract List<double> FuncValues(double t);

        public double Erro(IResultODE result)
        {
            double e = 0.0;
            for (int i = 0; i < result.Time.Count; i++)
            {
                double t = result.Time[i];
                List<double> calc = FuncValues(t);
                for (int j = 0; j < result.Result.Count; j++)
                {
                    e = Math.Abs(result.Result[j][i] - calc[j]);
                }
            }
            return e;
        }
        
    }
}
