namespace IO1202223ProfileTDD.Test
{
    [TestClass]
    public class EdgeSetTest
    {
        private const double AcceptablePrecision = 1e-8;

        [TestMethod]
        public void TestNormalizedAverageComputations()
        {
            List<double> distances = new List<double>();
            distances.Add(1.0);
            distances.Add(1.0);
            distances.Add(2.0);
            double expectedNormalizedAverage = 2.0 / 3.0;
            double realNormalizedAverage = EdgeSet.ComputeAverage(distances);
            Assert.AreEqual(expectedNormalizedAverage, realNormalizedAverage, AcceptablePrecision);
        }

        [TestMethod]
        public void TestForEmptyAndOnlyZeros()
        {
            double expectedNormalizedAverage = 0.0;
            List<double> distances = new List<double>();
            double realNormalizedAverage = EdgeSet.ComputeAverage(distances);
            Assert.AreEqual(expectedNormalizedAverage, realNormalizedAverage, AcceptablePrecision);

            distances.Add(0.0);
            distances.Add(0.0);
            distances.Add(0.0);
            realNormalizedAverage = EdgeSet.ComputeAverage(distances);
            Assert.AreEqual(expectedNormalizedAverage, realNormalizedAverage, AcceptablePrecision);
        }
    }
}