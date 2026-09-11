using System;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

string pattern = @"\bп[^а-яa-zA-Zіієє0-9\s]*[оo][^а-яa-zA-Zіієє0-9\s]*[гg][^а-яa-zA-Zіієє0-9\s]*[аa][^а-яa-zA-Zіієє0-9\s]*[нh][а-яa-zA-Zіієє]*\b";

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