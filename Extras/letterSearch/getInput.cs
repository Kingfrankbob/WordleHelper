namespace letterSearcher
{
    class getInput
    {
        public static string getString()
        {
            System.Console.WriteLine("Enter your letters, numbers, special characters, etc.:");
            var input = System.Console.ReadLine() ?? "";
            if (String.IsNullOrWhiteSpace(input) || String.IsNullOrEmpty(input))
            {
                System.Console.WriteLine("Please enter a valid input ;(");
                input = getString();
            }
            return input;
        }
        public static string getWordle()
        {
            System.Console.WriteLine("Enter your letters with underscores for unknown:");
            var input = System.Console.ReadLine() ?? "";
            if (input.Length > 5 || input.Length < 5)
            {
                System.Console.WriteLine("Please enter 5 letters, Seriously just a waste of time...");
                input = getWordle();
            }
            return input;
        }
        public static string getWordleKaU()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("LEAVE BLANK IF NO INPUT");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("Enter your letters with underscores for unknown: ");
            var input = System.Console.ReadLine() ?? "";
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) input = "_____";
            System.Console.WriteLine("Please enter the letters you know, that are incorrectly placed:");
            var input2 = System.Console.ReadLine() ?? "";
            if (String.IsNullOrEmpty(input2) || String.IsNullOrWhiteSpace(input2)) input2 = "~";
            System.Console.WriteLine("Please enter in the letters you know are NOT in the word:");
            var input3 = System.Console.ReadLine() ?? "";
            if (String.IsNullOrEmpty(input3) || String.IsNullOrWhiteSpace(input3)) input3 = "~";
            System.Console.WriteLine("Experimental, but places they are NOT (letter, place1, place2, placeX...):");
            var input4 = System.Console.ReadLine() ?? "";
            if (String.IsNullOrEmpty(input4) || String.IsNullOrWhiteSpace(input4)) input4 = "~";
            var returnable = input + "!@<<<()" + input2 + "!@<<<()" + input3 + "!@<<<()" + input4;
            return returnable;
        }
    }
}