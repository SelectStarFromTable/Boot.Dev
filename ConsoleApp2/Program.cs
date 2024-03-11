using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        var url = "https://raw.githubusercontent.com/asweigart/codebreaker/master/frankenstein.txt"; // Replace with your URL
        var content = await DownloadStringAsync(url);
        var words = content.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        var wordCount = words.Length; //71307
        Console.WriteLine(wordCount.ToString() + " words found in frankenstein.txt file.");
        Console.WriteLine();
        //count letters in array ..
        char [] letters =  ['a','b','c'];
        foreach (var item in letters) {
            var letter = content.ToLower().Count(c => c == item);
            Console.WriteLine(item.ToString() + " character total " + letter.ToString());
        }

    }

    public static async Task<string> DownloadStringAsync(string url)
    {
        using (var httpClient = new HttpClient())
        {
            string content = await httpClient.GetStringAsync(url);
            return content;
        }
    }
}

