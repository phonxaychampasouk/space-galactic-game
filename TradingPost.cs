using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class TradingPost
    {
        public InventoryList inventory = new InventoryList();

        public MainCharacter character = new MainCharacter();

        public double Trading()
        {
            Console.WriteLine("Welcome to Trades-R-US!");
            Console.WriteLine(" What will you like to trade?");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.WriteLine("[Chance your luck and gamble the dice for:] ");
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        return Uranium238();


                    }
                case ConsoleKey.D2:
                    {
                        return Diamond();

                    }
                case ConsoleKey.D3:
                    {
                        return Electricity();

                    }
                case ConsoleKey.D4:
                    {
                        return Coal();

                    }
                case ConsoleKey.D5:
                    {
                        return Wood();

                    }

                default:
                     return Trading(); 
                
            }
            
        }

        public double Uranium238()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.WriteLine("[Chance your luck and gamble the dice for:] ");
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        inventory.Uranium238 += 100;
                        character.storage += 50;
                        character.shillings -= 25000;
                        break;

                    }
                case ConsoleKey.D2:
                    {
                        inventory.Uranium238 -= 100;
                        character.storage += 50;
                        character.shillings += 25000;
                        break;
                    }
            }
            return inventory.Uranium238;

        }
        public double Diamond()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.WriteLine("[Chance your luck and gamble the dice for:] ");
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        inventory.diamond += 100;
                        //character.storage += 30;
                        character.shillings -= 20000;
                        break;

                    }
                case ConsoleKey.D2:
                    {
                        inventory.diamond -= 100;
                        //character.storage -= 30;
                        character.shillings += 2000;
                        break;
                    }
            }
            return inventory.diamond;
        }
        public double Electricity()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.WriteLine("[Chance your luck and gamble the dice for:] ");
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        inventory.electricty += 150;
                        // character.storage += 35;
                        character.shillings -= 1000;
                        break;

                    }
                case ConsoleKey.D2:
                    {
                        inventory.electricty -= 150;
                        // character.storage -= 35;
                        character.shillings += 10000;
                        break;
                    }
            }
            return inventory.electricty;
        }
        public double Coal()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.WriteLine("[Chance your luck and gamble the dice for:] ");
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        inventory.coal += 150;
                       // character.storage += 35;
                        character.shillings -= 10000;
                        break;

                    }
                case ConsoleKey.D2:
                    {
                        inventory.coal -= 100;
                        //character.storage -= 35;
                        character.shillings += 30000;
                        break;
                    }
            }
            return inventory.coal;
        }
        public double Wood()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.WriteLine("[Chance your luck and gamble the dice for:] ");
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        inventory.wood += 200;
                       // character.storage += 35;
                        character.shillings -= 10000;
                        break;

                    }
                case ConsoleKey.D2:
                    {
                        inventory.wood -= 200;
                       // character.storage -= 35;
                        character.shillings += 10000;
                        break;
                    }
            }
            return inventory.wood;
        }
    }
}


