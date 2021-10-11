using System;

namespace DnDDiceRollingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            do
            {
                System.Console.WriteLine("DnD Dice Rolling App");

                System.Console.WriteLine("Enter D20, D12, D10, D8, D6, or D4 to roll your die!");
                string inputDice = Console.ReadLine().ToUpper();
                string selectedDice = SelectDice(inputDice);
                System.Console.WriteLine(selectedDice);



                System.Console.WriteLine("Do you want to quit or roll again? Type Q to quit or any key to roll again.");
                string inputQuit = Console.ReadLine();
                if (inputQuit.ToLower() == "q")
                {
                    isRunning = false;
                }

            }
            while (isRunning);
        }
        public static string SelectDice(string dice) => dice switch
        {
            "D20" => $"20 sided dice rolling..\n You rolled a {RandomDiceRoll(21)}",
            "D12" => $"12 sided dice rolling..\n You rolled a {RandomDiceRoll(13)}",
            "D10" => $"10 sided dice rolling..\n You rolled a {RandomDiceRoll(11)}",
            "D8" => $"8 sided dice rolling..\n You rolled a {RandomDiceRoll(9)}",
            "D6" => $"6 sided dice rolling..\n You rolled a {RandomDiceRoll(7)}",
            "D4" => $"4 sided dice rolling..\n You rolled a {RandomDiceRoll(5)}",
            _ => "Invalid input"

        };
        public static int RandomDiceRoll(int dice)
        {
            Random rnd = new Random();
            return rnd.Next(1, dice);
        }
    }
}
