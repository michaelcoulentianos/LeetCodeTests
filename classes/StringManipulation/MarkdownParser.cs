using System.Collections;

namespace LeetCodeTests.classes.StringManipulation;

public class MarkdownParser
{
    public static string Parser(string markdown)
    {
        if (OverCharacterLimit('#', markdown, 8))
            return markdown;
        if (!HasWhiteSpace(markdown, "# "))
            return "#NoSpace";

        var transform = markdown.Trim(' ').Split(" ");
        var key = transform[0];
        string value = HtmlSetLookup(key);

        if (value == "")
            return "#Invalid";

        var length = transform?.Length;
        var content = "";
        for (int i = 1; i < length; ++i)
        {
            if (i == 1)
                content = transform?[i];
            else
                content += ' ' + transform?[i];
        }
        var result = value?.Replace(" ", content);
        if (result == null)
            return markdown;
        return result;
    }

    private static bool OverCharacterLimit(char charactor, string text, int limit)
    {
        var length = text.Length;
        var counter = 0;
        for (var i = 0; i < length; i++)
        {
            if (i + 1 == length)
                return false;
            var first = text[i];
            var second = text[i + 1];
            if (first == charactor && second == charactor)
                counter++;
            if (first == charactor && second == ' ')
                counter++;
            if (counter > limit)
                return true;
            if (first == charactor && second != charactor)
                counter = 0;
        }
        return false;
    }

    private static string HtmlSetLookup(string key)
    {
        var htmlSet = new Hashtable()
        {
            { "#", "<h1> </h1>" },
            { "##", "<h2> </h2>" },
            { "###", "<h3> </h3>" },
            { "####", "<h4> </h4>" },
            { "#####", "<h5> </h5>" },
            { "######", "<h6> </h6>" },
            { "#######", "<h7> </h7>" },
            { "########", "<h8> </h8>" }
        };

        string? result = Convert.ToString(htmlSet[key]);
        return result ?? "";
    }

    private static bool HasWhiteSpace(string input, string contains) => input.Contains(contains);
}
