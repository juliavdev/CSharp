using System.Text.RegularExpressions;

namespace Exercitando;
static class LogLine
{
    public static string Message(string logLine)
    {
        Regex regex = new Regex(@"(\[[A-Z]+\]:)");
        string message = regex.Replace(logLine, "");
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        Match matches = Regex.Match(logLine, @"(\[[A-Z]+\])");
        string log = matches.ToString();
        log = log.Remove(0,1);
        log = log.Remove((log.Length-1), 1);
        return log.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = LogLine.Message(logLine);
        message += $" ({LogLine.LogLevel(logLine)})";
        return message;
    }
}
