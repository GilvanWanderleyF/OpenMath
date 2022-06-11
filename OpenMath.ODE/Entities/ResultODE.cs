using OpenMath.ODE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMath.ODE
{
    public class ResultODE : IResultODE
    {
        private void Setup(double[] time, double[,] data)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Result.Add(new List<double>());
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    Result[j].Add(data[i, j]);
                    if (j==0)
                    {
                        Time.Add(time[i]);
                    }
                }
            }
        }
        public ResultODE(double[] time, double[,] data)
        {
            Setup(time, data);
        }

        public List<List<double>> Result { get; } = new();
        public List<double> Time { get;} = new();


    }
}
