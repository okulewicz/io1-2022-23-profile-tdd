namespace IO1202223ProfileTDD
{
    public class EdgeSet
    {
        public static double ComputeAverage(List<double> distances)
        {
            double max = distances.Max();
            return distances.Average(d => d / max);
        }
    }
}