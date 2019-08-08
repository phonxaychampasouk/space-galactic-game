using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class MainCharacter
    {
        public double shillings; // allowing users to access this variables
        public double fuel;

        public double storage;
        public int warpSpeed;
        public int age;
        public string shipName;


        public string planetName;
        public double distance;
        public string items;
        


        public MainCharacter()

        {
            this.warpSpeed = 0;
            this.shillings = 60000; // assigning values to the variables in this class
            this.fuel = 0;
            this.storage = 0;
            this.shipName = "";
            this.age = 18;
            this.planetName = "Ratin";
            this.distance = 0;
            this.items = "Wood";
            


        }
        //public static double MainCharacter()
        //{

        //}
        
        //public static (double, double, double, string) NewShipPurchase( double shillings = 60000, double fuel = 0, double storage = 0, string newShip = null)
        //{
        //    return (shillings, fuel, storage, newShip );

        //}
    }
}































//        int race;
//        int shillings;
//        int planets;
        

//    public static void CharacterRandom()
//    {
//        var character = new MainCharacter();
//        character.GenerateCharacter();
//        Console.WriteLine(character.ToString());
//    }
  
//        public MainCharacter()
//        {
//            _race = 1;
//            _shillings = 4000;
//            _planets = 1;


//        }
       
      
//        public MainCharacter( int race, int shillings, int planets)
//        {
            
//            this.race = race;
//            this.shillings = shillings;
//            this.planets = planets;


//        }

//        Random rnd = new Random();
//        public string CharacterName { get; set; }
//        private int _race;
//        public int Race
//        {
//            get { return _race; }
//            set
//            {
//                if (value >= 1 && value <= 2)
//                {
//                    ;
//                    _race = value;
//                }
//                else
//                {
//                    throw new System.Exception("Races can only be Human or Martian.");
//                }
//            }
//        }



//        public int _shillings;
//        public int Shillings
//        {
//            get { return _shillings; }
//            set
//            {
//                if (value >= 2000 && value <= 7000)
//                {
//                    _shillings = value;
//                }
//                else
//                {
//                    throw new System.Exception("Races can only be Human or Martian.");
//                }
//            }
//        }



//        public int _planets;
//        public int Planets
//        {
//            get { return _planets; }
//            set
//            {
//                if (value >= 1 && value <= 2)
//                {
//                    _planets = value;
//                }
//                else
//                {
//                    throw new System.Exception($"{CharacterName} can only start out in Utopia or Atlantis.");
//                }
//            }
//        }

//        public int RollAttributeScore()
//        {
//            int score = rnd.Next(2000, 7000);
//            return score;
//        }

//        private int RollAttributeScore2() //for planet and shillings
//        {
//            Random rnd2 = new Random();
//            int score = rnd2.Next(1, 3);
//            return score;
//        }

//        public void GenerateCharacter()
//        {
//            {
//                Shillings = RollAttributeScore();
//                Planets = RollAttributeScore2();
//                Race = RollAttributeScore2();

//            }
//        }
//        public override string ToString()
//        {
//            var characterString = new StringBuilder();
//            characterString.AppendLine(" Character Name: " + this.CharacterName);
//            characterString.AppendLine("Race: " + Race);
//            characterString.AppendLine("Shillings:" + Shillings);
//            characterString.AppendLine("Planet:" + Planets);

//            return characterString.ToString();
//        }


//        //static void List()
//        //{
//        //    List<string> fileLines = new List<string>();

//        //    using (var reader = new StreamReader("C:\\Users\\pc\\source\repos\\Shell_Space_Cadets\\RandomName.txt"))
//        //    {
//        //        string line;
//        //        while ((line = .ReadLine()) != null)
//        //        {
//        //            fileLines.Add(line);
//        //        }
//        //    }
//        //}



//    }
//}