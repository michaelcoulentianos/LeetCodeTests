namespace LeetCodeTests.classes.numbers;

public class PossibleTwoPairs
{
    public static int FindPairs(int n)
    {
        HashSet<string> pairs = new();
        List<string> players = new();
        for (int i = 0; i < n; i++) players.Add($"T{i}");

        for (int x = 0; x < n; x++)
        {
            for (int y = 1; y < n; y++)
            {
                if (players[x] == players[y]) continue;
                var player = $"{players[x]}{players[y]}";
                var reverse = $"{players[y]}{players[x]}";
                if (!pairs.Contains(player) && !pairs.Contains(reverse)) pairs.Add(player);
            }
        }

        return pairs.Count();
    }
}
