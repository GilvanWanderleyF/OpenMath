namespace OpenMath.ODE.Entities
{
    internal static class CheckODE
    {


        public static void Dimension(DiffEquation[] equations, double[] initialCond)
        {
            if (equations.Length != initialCond.Length)
            {
                throw new Exception(message:
                    $"The number of equations ({equations.Length}) is different from " +
                    $"the number of initial conditions ({initialCond.Length}).");
            }
            else if (equations.Length == 0)
            {
                throw new Exception(message: "Differential equations are empty.");
            }
        }

        public static void TimeConditions(double initial, double final)
        {
            if (final < initial)
            {
                throw new Exception(message: "The end time is less than the start time");
            }
        }

        public static void ValidValue(double value)
        {
            if (!double.IsNormal(value))
            {
                throw new Exception(message: $"The value is not normal (value: {value})");
            }
        }
    }
}
