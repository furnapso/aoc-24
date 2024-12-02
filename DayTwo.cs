namespace aoc_24;

public class DayTwo
{
    public static void Run(SantasList data)
    {
        var frequencyMap = new Dictionary<int, int>();

        foreach (var num in data.Right.Where(num => !frequencyMap.TryAdd(num, 1)))
        {
            frequencyMap[num]++;
        }

        var similarityScore = data.Left.Sum(num => num * frequencyMap.GetValueOrDefault(num, 0));

        Console.WriteLine(similarityScore);
    }
}