using System;
namespace Lab7
{
    public static class MonteCarlo
    {
        public static double Calculate(double totalPoints)
        {
            double circleRound = 1;
            int circlePointsCount = 0;

            Random rnd = new Random();

            for (int i = 0; i < totalPoints; i++)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();

                if (Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 2)) <= circleRound)
                {
                    circlePointsCount++;
                }

            }

            return 4d * (circlePointsCount / totalPoints);
        }
    }
}
