namespace letterSearcher
{
    class wordleSearch
    {
        public static void Search(string input)
        {
            int minmaxLength = 5;
            var allWords = File.ReadAllLines("letterSearch.txt");
            var endWords = new List<string>();
            var debug = false;
            var charlist = new char[input.Length];
            for (int i = 0; i < input.Length; i++) charlist[i] = input[i];

            foreach (var word in allWords)
            {
                if (word.Length > minmaxLength || word.Length < minmaxLength || word.Contains('\'')) continue;

                int counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (input[i] == '_') { counter++; }
                    if (word[i] == charlist[i])
                    {
                        counter++;
                        if (debug) System.Console.WriteLine(word[i] + " " + charlist[i] + " " + " Pass " + counter);
                    }
                    if (counter == 5)
                    {
                        endWords.Add(word);
                    }
                }
            }
            Printer.printWords(endWords);
        }
        public static void SearchWith(string known, string exists, string notin, string letterPlaces)
        {
            int minmaxLength = 5;
            var allWords = File.ReadAllLines("letterSearch.txt");
            var endWords = new List<string>();
            var debug = false;
            bool exist = true, notins = true, letterPL = true;
            if (exists == "~") exist = false;
            if (notin == "~") notins = false;
            if (letterPlaces == "~") letterPL = false;
            var knownlist = new Dictionary<int, char>();

            if (letterPL)
            {
                try
                {
                    var letterPlacesList = letterPlaces.Split('(');
                    foreach (var letterPlace in letterPlacesList)
                    {
                        var letterPlaceList = letterPlace.Trim(')');
                        var letterPlaceList2 = letterPlaceList.Split(',');
                        var letter = letterPlaceList2[0];
                        int counterr = 0;
                        foreach (var place in letterPlaceList2)
                        {
                            if (place == letter) continue;
                            knownlist.Add(int.Parse(place) - 1, char.Parse(letter));
                        }
                    }
                }
                catch (Exception)
                { /* ignored */ }
            }

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
                    if (word[i].ToString().ToLower() == known[i].ToString().ToLower())
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
                if (letterPL)
                    foreach (var value in knownlist)
                        if (word[value.Key] == value.Value) passOn = true;
                if (passOn) continue;

                endWords.Add(word);
            }
            Printer.printWords(endWords);
        }

    }
}