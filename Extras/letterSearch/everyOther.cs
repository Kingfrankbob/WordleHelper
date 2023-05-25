namespace letterSearcher
{
    class everyOther
    {
        public static void anyOther(string input)
        {
            var charlist = new char[input.Length];
            var total = input.Length;
            var maxletters = total * 2 + 1;
            var minletters = total * 2;
            var endWords = new List<string>();
            var allWords = File.ReadAllLines("letterSearch.txt");
            var debug = false;

            for (int i = 0; i < input.Length; i++)
            {
                charlist[i] = input[i];
            }

            foreach (var word in allWords)
            {
                if (word.Length > maxletters || word.Length < minletters) continue;
                int counter = -1;
                int numCount = 0;
                for (int i = 0; i < total; ++i)
                {
                    counter += 2;
                    if (debug) System.Console.WriteLine(counter + " " + i);
                    if (word[counter] == charlist[i])
                    {
                        ++numCount;
                        if (debug) System.Console.WriteLine(word[counter] + " " + charlist[i] + " " + " Pass ");
                    }
                    if (numCount == total)
                    {
                        endWords.Add(word);
                    }
                }
            }
            Printer.printWords(endWords);

        }
    }
}