// See https://aka.ms/new-console-template for more information
using IO1202223ProfileTDD;

Console.WriteLine("Hello, World!");
Random random = new Random(Seed: 1);
List<double> distances = new List<double>();
for (int i = 0;i < 1000000; i++)
{
    distances.Add(random.Next(maxValue: 30));
}
double result = EdgeSet.ComputeAverage(distances);
Console.WriteLine(result);