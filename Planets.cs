using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class SpaceFlight
    {
        public MainCharacter characterPlanet = new MainCharacter();
        public InventoryList itemsForTrade = new InventoryList();
        public TradingPost trading = new TradingPost();


        public (double, double, double) SpaceTravel()
        {
            Console.WriteLine("1. Proxima Centauri     2. Utopia        3. Earth    ");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        ProximaCentauri();
                        trading.Trading();
                        Console.WriteLine(ProximaCentauri());
                        Console.WriteLine("proxima centauri");
                        Console.ReadLine();
                        Console.WriteLine(trading.Trading());
                        Console.WriteLine("trading post");
                        Console.ReadLine();

                        return ProximaCentauri();


                    }
                case ConsoleKey.D2:
                    {
                        Utopia();
                        trading.Trading();
                        return Utopia();
                    }
                case ConsoleKey.D3:
                    {
                        Earth();
                        trading.Trading();
                        return Earth();
                    }

                default:
                    return Earth();
            }
        }


        public (double, double, double) ProximaCentauri()
        {

            characterPlanet.distance = 2.4 * (10 ^ 12);
            characterPlanet.fuel -= 75;
            characterPlanet.age += 10;



            return (characterPlanet.fuel, characterPlanet.age, characterPlanet.distance);
        }

        public (double, double, double) Utopia()
        {

            characterPlanet.distance = 2.4 * (10 ^ 12);
            characterPlanet.fuel -= 75;
            characterPlanet.age += 10;



            return (characterPlanet.fuel, characterPlanet.age, characterPlanet.distance);

        }

        public (double, double, double) Earth()
        {

            characterPlanet.distance = 2.4 * (10 ^ 12);
            characterPlanet.fuel -= 75;
            characterPlanet.age += 10;



            return (characterPlanet.fuel, characterPlanet.age, characterPlanet.distance);

        }
    }
}
