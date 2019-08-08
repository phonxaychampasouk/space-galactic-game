using System;

namespace random
{
    class Program
    {
        public static void Main()
        {

            Ship ship = new Ship();
            MainCharacter character = new MainCharacter();
            SpaceFlight space = new SpaceFlight();
            UserInterface ui = new UserInterface();
            TradingPost random = new TradingPost();

            ui.UserInterface1();
            StoryLine.MainStoryLine();
            ui.WhereToGo();







            Console.WriteLine();
            Travel.WarpSpeed();
            //Planets.PlanetGenerate();
            //userInterface.UserInterface();
            //MainCharacter.CharacterRandom();
            //StoryLine.MainStoryLine();



            /*
             
             
             
             Trade, and Game Concepts[] <-- pass in array
             
             
             
             
             
             */



            /*
             Game Ending



            */
        }



    }
}



