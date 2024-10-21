using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Text
{
    static void Main(string[] args)
    {
        var sentence = "you look very handsome in these clothes and your voice is awesome";
        var summary = SummarizeText(sentence);
        Console.WriteLine(summary);

    }

    static string SummarizeText(string text)
    {
        const int maxLength = 20;

        if (text.Length < maxLength)
        {
            return text;
    }
            
        var words = text.Split(' ');
        var totalChar = 0;
        var summaryWords = new List<string>();
        foreach (var word in words)
        {
            summaryWords.Add(word);

            totalChar += word.Length + 1;
            if (totalChar > maxLength)

                break;

        }
        var summary = String.Join(" ", summaryWords + " ");
        return summary;
    }
        
}
}
