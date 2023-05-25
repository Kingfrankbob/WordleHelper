using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleRefr
{
    public class Calculator
    {
        public static List<string> SearchWith(string known, string exists, string notin)
        {
            int minmaxLength = 5;
            var allWords = alphaList.allWords;
            var endWords = new List<string>();
            var debug = false;
            bool exist = true, notins = true;
            if (exists == "~") exist = false;
            if (notin == "~") notins = false;
            var knownlist = new Dictionary<int, char>();
            if (debug) foreach (var value in knownlist) System.Console.WriteLine(value.Key + " " + value.Value);
            if (debug) System.Console.WriteLine("Known: " + known + " Exists: " + exists);
            foreach (var word in allWords)
            {
                if (word.Length > minmaxLength || word.Length < minmaxLength || word.Contains('\\')) continue;
                var passOn = false;
                int counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (known[i] == '_') { counter++; }
                    if (word[i] == known[i])
                    {
                        counter++;
                        if (debug) System.Console.WriteLine(word[i] + " " + known[i] + " " + " Pass " + counter);
                    }
                    if (counter != 5) passOn = true;
                    else if (counter == 5) passOn = false;
                }
                if (passOn) continue;
                if (notins)
                    for (int i = 0; i < 5; i++)
                        foreach (var chara in notin)
                            if (word[i] == chara) passOn = true;
                if (passOn) continue;
                if (exist)
                    for (int i = 0; i < 5; ++i)
                        foreach (var chara in exists)
                            if (!word.Contains(chara)) passOn = true;
                if (passOn) continue;

                endWords.Add(word);
            }
            return endWords;
        }
    }
}