namespace IO1202223ProfileTDD
{
    public class EdgeSet
    {
        public static double ComputeAverage(List<double> distances)
        {
            return distances.Average(d => d / distances.Max());
        }
    }
}