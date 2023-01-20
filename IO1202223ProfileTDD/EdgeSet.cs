namespace IO1202223ProfileTDD
{
    public class EdgeSet
    {
        public static double ComputeAverage(List<double> distances)
        {
            if (!distances.Any())
            {
                return 0;
            }
            if (distances.Distinct().Count() <= 1)
            {
                return 0;
            }
            double max = distances.Max();
            return distances.Average(d => d / max);
        }
    }
}