using System;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

string pattern =@"\b[пp][^а-яa-zA-Zіієєґґ\s]*[оo][^а-яa-zA-Zіієєґґ\s]*[гg][^а-яa-zA-Zіієєґґ\s]*[аa][^а-яa-zA-Zіієєґґ\s]*[нh][а-яa-zA-Zіієєґґ]*\b";

while (true)
{
    Console.Write("Введіть текст (або натисніть Enter для виходу): ");
    string text = Console.ReadLine();

    if (string.IsNullOrEmpty(text))
    {
        break;
    }

    string filteredText = Regex.Replace(text, pattern, "***", RegexOptions.IgnoreCase | RegexOptions.Multiline);
    Console.WriteLine("Відфільтрований текст: " + filteredText + "\n");
}