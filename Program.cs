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

                System.Console.WriteLine("Enter D20, D12, D10, D8, D6, or D4 to roll your die! Enter H, GH, SH, or SUPH for heal rolls.");
                string inputDice = Console.ReadLine().ToUpper();
                string selectedDice = SelectDice.DiceResult(inputDice);
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
    }
}
