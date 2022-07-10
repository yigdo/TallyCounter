namespace tallycounter
{
    class TallyCounter
    {
        public int Counter;

        public int PrayGoal;

        public string PrayWord;

        public TallyCounter()
        {
            Banner();
            System.Console.Write("Write a word to pray for: ");
            PrayWord = System.Console.ReadLine();
            System.Console.Write("Pray Goal: ");
            PrayGoal = int.Parse(System.Console.ReadLine());

            for (int c = 0; Counter < PrayGoal; c++)
            {
                StartPray();
            }
            Congrats();
        }

        private void Banner()
        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Tally Counter Software");
            System.Console.WriteLine("----------------------");
        }

        private void StartPray()
        {
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.Clear();
            System.Console.Write("Your Word is {0}. ", PrayWord);
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("Counter: " + Counter);
            System.Console.ForegroundColor = System.ConsoleColor.White;

            System.Console.WriteLine();
            System.Console.Write("Word: ");
            string Word = Console.ReadLine();
            if (Word == PrayWord)
            {
                Counter += 1;
            }
            else
            {
                Counter -= 1;
            }
        }

        public void Congrats()
        {
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.Clear();

            Banner();
            System.Console.WriteLine("Congrats of reaching your daily goal of {0}.",PrayGoal);
        }
    }
}
