public class Subsequences
{
    public static bool IsSubsequence(string s, string t)
    {
        var sequence = s.ToArray();
        var length = sequence.Length;
        var position = 0;

        for (var i = 0; i < length; i++)
        {
            var seq = sequence[i];
            var current = t.IndexOf(seq);
            if (current == -1) return false;
            t = t.Remove(0, current+1);

            if (position <= current) position = current;
            else return false;
        }

        return true;
    }
}