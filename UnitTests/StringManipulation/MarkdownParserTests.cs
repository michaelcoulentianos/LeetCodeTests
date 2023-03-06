using LeetCodeTests.classes.StringManipulation;

namespace LeetCodeTests.UnitTests.StringManipulation;

public class MarkdownParserTests
{
    [TestCase(ExpectedResult = "<h6>Heading</h6>")]
    public string Parsing_Heading_Six()
    {
        var result = MarkdownParser.Parser("###### Heading");
        return result;
    }

    [TestCase(ExpectedResult = "#NoSpace")]
    public string Parsing_Heading_NoSpace()
    {
        var result = MarkdownParser.Parser("######Heading");
        return result;
    }

    [TestCase(ExpectedResult = "<h8>Heading</h8>")]
    public string Parsing_Heading_Eight()
    {
        var result = MarkdownParser.Parser("######## Heading");
        return result;
    }

    [TestCase(ExpectedResult = "######### Heading")]
    public string Parsing_Heading_Markdown()
    {
        var result = MarkdownParser.Parser("######### Heading");
        return result;
    }

    [TestCase(ExpectedResult = "#Invalid")]
    public string Parsing_Heading_Invalid()
    {
        var result = MarkdownParser.Parser("###*##### Heading");
        return result;
    }

    [TestCase(ExpectedResult = "<h6>Cool Cats</h6>")]
    public string Parsing_Heading_Cool_Cats()
    {
        var result = MarkdownParser.Parser("###### Cool Cats");
        return result;
    }
}
