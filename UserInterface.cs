using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class userInterface
    {
        Ship ship = new Ship();
        MainCharacter character = new MainCharacter();
        SpaceFlight space = new SpaceFlight();
        TradingPost random = new TradingPost();

        public void UserInterface()
        {
            Console.Write(new string('\n', 10));
            Console.WriteLine(" 1. START GAME | 2. END GAME | 3. END GAME | 4. END GAME.");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        StoryLine.MainStoryLine();
                        Console.Clear();
                        break;
                    }
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                    {
                        Console.Write("\n" + "\n" + "good idea, but you should have looked");
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    }
            }
        }


        public void WhereToGo()
        {
            Console.Write(new string('\n', 10));
            Console.WriteLine(" 1. Trading Post  | 2.  Purchase Ship | 3. Travel planets |  ");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        random.Trading();

                        Console.Clear();
                        break;
                    }
                case ConsoleKey.D2:
                    {

                        ship.SpaceLot();
                        Console.WriteLine($" New Total shillings: {character.shillings}, New Fuel Capacity: {character.fuel}, New Storage Limit: {character.storage}, and your new ship is named {character.shipName }");
                        break;

                    }
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                    {
                        Console.Write("\n" + "\n" + "good idea, but you should have looked");
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    }

            }
        }
    }
}

