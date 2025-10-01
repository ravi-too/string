using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = "today is a good day for walking. i will try to walk near the sea";
        string input2 = "today is good. me var giorgi da ar minda qartuli sheicvalos.";

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Processed: " + CapitalizeSentences(input));
        Console.WriteLine();
        Console.WriteLine("Original: " + input2);
        Console.WriteLine("Processed: " + CapitalizeSentences(input2));
    }

    static string CapitalizeSentences(string text)
    {
        if (string.IsNullOrEmpty(text)) return text;

        var sb = new StringBuilder(text.Length);
        bool capitalizeNextLetter = true;

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (capitalizeNextLetter && c >= 'a' && c <= 'z')
            {
                sb.Append((char)(c - 32));
                capitalizeNextLetter = false;
            }
            else
            {
                sb.Append(c);
                if (c == '.' || c == '!' || c == '?')
                {
                    capitalizeNextLetter = true;
                }
            }
        }

        return sb.ToString();
    }
}
