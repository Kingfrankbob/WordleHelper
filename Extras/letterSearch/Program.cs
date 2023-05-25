namespace letterSearcher
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine(@"Please enter an input
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The options are:
0. Exit
1. Every other letter
2. Wordle with only know
3. Wordle with known, and non-placed letters 
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            var choice = 0;
            try
            {
                var inputN = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                choice = inputN;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid input");
                Main(args);
            }
            var input = "";
            switch (choice)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Goodbye :)");
                    Console.Beep();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Environment.Exit(0);
                    break;
                case 1:
                    input = getInput.getString();
                    everyOther.anyOther(input);
                    break;
                case 2:
                    input = getInput.getWordle();
                    wordleSearch.Search(input);
                    break;
                case 3:
                    input = getInput.getWordleKaU();
                    var each = input.Split("!@<<<()");
                    wordleSearch.SearchWith(each[0], each[1], each[2], each[3]);
                    break;
            }
        }
    }
}