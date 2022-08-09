using System.Text.RegularExpressions;

namespace Exercitando;

public static class LogAnalysis
{

    public static string SubstringAfter(this string message, string delimiter)
    {
        string[] log = message.Split(delimiter);

        return log[1];
    }

    public static string SubstringBetween(this string message, string delimiterOne, string delimiterTwo)
    {
        string delimiterOneCopy = delimiterOne;
        string delimiterTwoCopy = delimiterTwo;

        if(delimiterOne.Contains(" "))
        {
            delimiterOne = delimiterOne.Replace(" ", @"\s");
        }
        if(delimiterTwo.Contains(" "))
        {
            delimiterTwo = delimiterTwo.Replace(" ", @"\s");
        }
       
        Match matches = Regex.Match(message, $"({delimiterOne}[A-Z]+{delimiterTwo})");
        string formattedByRegex = matches.ToString();
        if(formattedByRegex != "")
        {
            formattedByRegex = formattedByRegex.Remove(0, delimiterOneCopy.Length);
            //formattedByRegex = formattedByRegex.Remove(0, delimiterOne.Length-1);
            formattedByRegex = formattedByRegex.Remove((formattedByRegex.Length - delimiterTwoCopy.Length), delimiterTwoCopy.Length);

            return formattedByRegex;
        }
        else
        {
            return "Something unexpected happened.";
        }

    }

    public static string Message(this string message)
    {
        Regex regex = new Regex(@"(\[[A-Z]+\]:)");
        string logLine = regex.Replace(message, "");
        return logLine.Trim();
    }

    public static string LogLevel(this string message)
    {
        Match matches = Regex.Match(message, @"(\[[A-Z]+\])");
        string log = matches.ToString();
        log = log.Remove(0, 1);
        log = log.Remove((log.Length - 1), 1);
        return log;
    }

}