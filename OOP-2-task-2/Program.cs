using System;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

string pattern = @"\b[пp][^а-яa-zA-Zіієє\s]*[оo][^а-яa-zA-Zіієє\s]*[гg][^а-яa-zA-Zіієє\s]*[аa][^а-яa-zA-Zіієє\s]*[нh][а-яa-zA-Zіієє]*\b";

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