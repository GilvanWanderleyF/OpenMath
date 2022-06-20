using OpenMath.ODE.Entities;
using OpenMath.ODE.Interfaces;

namespace OpenMath.ODE.Discretizations
{
    public class DiscretizationPoints : IMethodDiscretization
    {
        public static DiscretizationPoints Create() => new DiscretizationPoints();
        public DiscretizationPoints() { Setup(); }
        public DiscretizationPoints Setup(int numPoints = 10)
        {
            _numPoints = numPoints;
            return this;
        }


        private int _numPoints;
        public int NumPoints { get => _numPoints; set => _numPoints = value; }


        public double[] Discretization(double initial, double final)
        {
            ValidatorODE.TimeValues(initial, final);

            double step = (final - initial) / _numPoints;

            double[] t = new double[_numPoints];
            t[0] = initial;
            for (int i = 1; i < _numPoints - 1; i++)
            {
                t[i] = t[i - 1] + step;
            }
            t[_numPoints - 1] = final;
            return t;
        }
    }
}
