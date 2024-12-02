namespace aoc_24;

public class DayTwo
{
    public static void Run(SantasList data)
    {
        var frequencyMap = new Dictionary<int, int>();

        foreach (var num in data.Right)
        {
            if (!frequencyMap.ContainsKey(num))
            {
                frequencyMap.Add(num, 1);
            }
            else
            {
                frequencyMap[num]++;
            }
        }

        var similarityScore = 0;

        foreach (var num in data.Left)
        {
            similarityScore += num * frequencyMap.GetValueOrDefault(num, 0);
        }

        Console.WriteLine(similarityScore);
    }
}