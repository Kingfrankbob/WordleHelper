namespace letterSearcher
{
    class Printer
    {
        public static void printWords(List<string> words)
        {
            System.Console.WriteLine("Total matched words: " + words.Count);
            words.Sort();
            int maxPerLine = Console.WindowWidth - 5;
            int lineCount = 0;
            var previousLetter = "";
            foreach (var word in words)
            {
                var firstLetter = word[0].ToString().ToLower();
                if (firstLetter != previousLetter)
                {
                    Console.WriteLine();
                    Console.WriteLine("Category, Starting with " + firstLetter.ToUpper() + ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    previousLetter = firstLetter;
                    lineCount = 0;
                }
                int lineCountTemp = lineCount + word.Length;
                if (lineCountTemp > maxPerLine)
                {
                    Console.WriteLine();
                    lineCount = 0;
                }
                Console.Write(word + ' ');
                lineCount += word.Length + 1;
            }
        }
    }
}