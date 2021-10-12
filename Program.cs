using System;

namespace DnDDiceRollingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Console.WriteLine("***DnD Dice Rolling App***");
            do
            {
                DisplayDice();
                RollAgain();
            }
            while (isRunning);

            void DisplayDice()
            {

                Console.WriteLine("Enter D20, D12, D10, D8, D6, or D4 to roll your die! Enter H, GH, SH, or SUPH for heal rolls.");
                string inputDice = Console.ReadLine().ToUpper();
                string selectedDice = SelectDice.DiceResult(inputDice);
                Console.WriteLine(selectedDice);
            }
            void RollAgain()
            {
                Console.WriteLine("Do you want to quit or roll again? Type Q to quit or any key to roll again.");
                string inputQuit = Console.ReadLine();
                if (inputQuit.ToLower() == "q")
                {
                    isRunning = false;
                }
            }
        }
    }
}
