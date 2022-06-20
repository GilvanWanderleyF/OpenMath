using OpenMath.ODE.Entities;
using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Discretizations
{
    public class DiscretizationStep : IMethodDiscretization
    {
        public static DiscretizationStep Create() => new DiscretizationStep();
        public DiscretizationStep() { Setup(); }
        public DiscretizationStep Setup(double step = 0.01)
        {
            _step = step;

            return this;
        }


        private double _step;
        public double Step { get => _step; set => _step = value; }


        public double[] Discretization(double initial, double final)
        {
            ValidatorODE.TimeValues(initial, final);

            int n = (int)Math.Round((final - initial) / Step) + 1;
            double[] t = new double[n];
            t[0] = initial;
            for (int i = 1; i < n - 1; i++)
            {
                t[i] = t[i - 1] + Step;
            }
            t[n - 1] = final;
            return t;
        }
    }


}
