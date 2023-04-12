using System.Text.RegularExpressions;

public static class Helper
{
    public static bool regexValidator(string input)
    {
        Regex rx = new Regex(@"^-?\d+(\.\d+)?\s+-?\d+(\.\d+)?$");
        return rx.IsMatch(input);
    }
}
