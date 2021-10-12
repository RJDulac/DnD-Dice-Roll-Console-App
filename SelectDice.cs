using System;

namespace DnDDiceRollingApp
{
    public static class SelectDice
    {
        private static int d4One = RandomDiceRoll(5);
        private static int d4Two = RandomDiceRoll(5);
        private static int d4Three = RandomDiceRoll(5);
        private static int d4Four = RandomDiceRoll(5);
        private static int d4Five = RandomDiceRoll(5);
        private static int d4Six = RandomDiceRoll(5);
        private static int d4Seven = RandomDiceRoll(5);
        private static int d4Eight = RandomDiceRoll(5);
        private static int d4Nine = RandomDiceRoll(5);
        private static int d4Ten = RandomDiceRoll(5);
        public static string DiceResult(string dice) => dice switch
        {
            "D20" => $"20 sided dice rolling..\n You rolled a {RandomDiceRoll(21)}",
            "D12" => $"12 sided dice rolling..\n You rolled a {RandomDiceRoll(13)}",
            "D10" => $"10 sided dice rolling..\n You rolled a {RandomDiceRoll(11)}",
            "D8" => $"8 sided dice rolling..\n You rolled a {RandomDiceRoll(9)}",
            "D6" => $"6 sided dice rolling..\n You rolled a {RandomDiceRoll(7)}",
            "D4" => $"4 sided dice rolling..\n You rolled a {RandomDiceRoll(5)}",
            "H" => $"Two 4 sided dice rolling..\n You rolled a {d4One} and a {d4Two}. You heal for {d4One + d4Two + 2}",
            "GH" => $"Four 4 sided dice rolling..\n You rolled a {d4One}, {d4Two}, {d4Three} and a {d4Four}. You heal for {d4One + d4Two + d4Three + d4Four + 4}",
            "SH" => $"Eight 4 sided dice rolling..\n You rolled a {d4One}, {d4Two}, {d4Three}, {d4Four}, {d4Five}, {d4Six}, {d4Seven} and a {d4Eight}. You heal for {d4One + d4Two + d4Three + d4Four + d4Five + d4Six + d4Seven + d4Eight + 8}",
            "SUPH" => $"Ten 4 sided dice rolling..\n You rolled a {d4One}, {d4Two}, {d4Three}, {d4Four}, {d4Five}, {d4Six}, {d4Seven}, {d4Eight}, {d4Nine} and a {d4Ten}. You heal for {d4One + d4Two + d4Three + d4Four + d4Five + d4Six + d4Seven + d4Eight + d4Nine + d4Ten + 20}",
            _ => "Invalid input"

        };
        private static int RandomDiceRoll(int dice)
        {
            Random rnd = new Random();
            return rnd.Next(1, dice);
        }
    }
}