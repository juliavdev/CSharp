using System.Text.RegularExpressions;

namespace Exercitando;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().EndsWith("?"))
        {
            string toUpper = statement.ToUpper();
            Match matches = Regex.Match(toUpper, "[A-Z]");
            if (toUpper == statement && matches.ToString() != "")
            {
                return "Calm down, I know what I'm doing!";
            }
            else
            {
                return "Sure.";
            }
        }

        if(statement.Trim() == "")
        {
            return "Fine. Be that way!";
        } else
        {
            string toUpper = statement.ToUpper();
            Match matches = Regex.Match(toUpper, "[A-Z]");
            if (toUpper == statement && matches.ToString() != "")
            {
                return "Whoa, chill out!";
            }
            else
            {
                return "Whatever.";
            }
        }
    }
}