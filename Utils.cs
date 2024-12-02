using System.Reflection;

namespace aoc_24;

public class Utils
{
    private static string ResourceName = "aoc_24.Resources.1.txt";

    public static SantasList GetData()
    {
        var lines = new List<string>();
        var assembly = Assembly.GetExecutingAssembly();
        var stream = assembly.GetManifestResourceStream(ResourceName);
        using var reader = new StreamReader(stream!);
        var line = reader.ReadLine();
        while (line != null)
        {
            lines.Add(line);
            line = reader.ReadLine();
        }

        var left = new List<int>();
        var right = new List<int>();

        foreach (var parts in lines.Select(line => line.Split(" ", StringSplitOptions.RemoveEmptyEntries)))
        {
            left.Add(int.Parse(parts[0]));
            right.Add(int.Parse(parts[1]));
        }

        return new SantasList
        {
            Left = left,
            Right = right
        };
    }
}