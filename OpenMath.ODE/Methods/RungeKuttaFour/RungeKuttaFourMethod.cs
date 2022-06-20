using OpenMath.ODE.Core;
using OpenMath.ODE.Entities;

namespace OpenMath.ODE.Methods.RungeKuttaFour
{
    public class RungeKuttaFourMethod : MethodODE
    {
        public static RungeKuttaFourMethod Create() => new RungeKuttaFourMethod();
        public RungeKuttaFourMethod() { }


        public override double[,] Solve(DifferentialEquation[] funcs, double[] initialCond, double[] time)
        {            
            double[,] result = new double[time.Length, initialCond.Length];

            for (int i = 0; i < time.Length; i++)
            {
                for (int j = 0; j < funcs.Length; j++)
                {
                    double h;
                    double[] k1 = new double[funcs.Length];
                    double[] k2 = new double[funcs.Length];
                    double[] k3 = new double[funcs.Length];
                    double[] k4 = new double[funcs.Length];
                    double[] yn0 = new double[funcs.Length];
                    double[] yn1 = new double[funcs.Length];
                    double[] yn2 = new double[funcs.Length];
                    double[] yn3 = new double[funcs.Length];

                    if (i == 0)
                    {
                        result[i, j] = initialCond[j];
                    }
                    else
                    {
                        h = time[i] - time[i - 1];
                        for (int a = 0; a < funcs.Length; a++)
                        {
                            yn0[a] = result[i - 1, a];
                        }
                        for (int a = 0; a < funcs.Length; a++)
                        {
                            k1[a] = h * funcs[a](time[i - 1], yn0);
                            yn1[a] = yn0[a] + k1[a] / 2.0;
                        }
                        for (int a = 0; a < funcs.Length; a++)
                        {
                            k2[a] = h * funcs[a](time[i - 1] + h / 2.0, yn1);
                            yn2[a] = yn0[a] + k2[a] / 2.0;
                        }
                        for (int a = 0; a < funcs.Length; a++)
                        {
                            k3[a] = h * funcs[a](time[i - 1] + h / 2.0, yn2);
                            yn3[a] = yn0[a] + k3[a];
                        }
                        for (int a = 0; a < funcs.Length; a++)
                        {
                            k4[a] = h * funcs[a](time[i - 1] + h, yn3);
                        }

                        double v = yn0[j] + (k1[j] + 2 * k2[j] + 2 * k3[j] + k4[j]) / 6.0;
                        ValidatorODE.Double(v);
                        result[i, j] = v;
                    }
                }
            }
            return result;
        }

    }
}
