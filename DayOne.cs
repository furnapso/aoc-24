using System.Reflection;

namespace aoc_24;

public static class DayOne
{
    public static void Run(SantasList data)
    {
        data.Left.Sort();
        data.Right.Sort();
        var totalDistance = data.Left.Select((t, i) => Math.Abs(t - data.Right[i])).Sum();

        Console.WriteLine(totalDistance);
    }
}