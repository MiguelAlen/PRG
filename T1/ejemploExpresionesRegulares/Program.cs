using System;
using System.Text.RegularExpressions;

public class Class1
{
    public static void Main()
    {
        //https://docs.microsoft.com/es-es/dotnet/api/system.text.regularexpressions.regex.match?view=net-5.0#System_Text_RegularExpressions_Regex_Match_System_String_System_String_System_Text_RegularExpressions_RegexOptions_System_TimeSpan_
        //string palabra = "El";
        //sring pattern = @"\b"+ palabra;t
        string pattern = @"\bEl\w*\b";
        string input = "Los elementos en el rio el.";
        Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
        if (m.Success)
            Console.WriteLine("Encontrado '{0}' en la posicion {1}.", m.Value, m.Index);
    }
}
