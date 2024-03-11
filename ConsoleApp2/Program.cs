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
        Console.WriteLine(wordCount);
        //count letters
        char [] letters =  ['a','b','c'];
        //var letter = content.ToLower().Count(c => c == 'a');//26743
        foreach (var item in letters) {
            var letter = content.ToLower().Count(c => c == item);
            Console.WriteLine(letter);
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

