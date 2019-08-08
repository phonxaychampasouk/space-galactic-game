using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class Ship
    {

        public MainCharacter character1 = new MainCharacter(); //character1 allows users to access specific items in this class by changing the class into a variable which
                                                               // can be called upon.
        public (double, double, double, int, string) SpaceLot() //returning a tuple to Spacelot
        {
            Console.WriteLine("Welcome to the SpaceLot, what would you like to purchase");
            Console.WriteLine("1. SupermarineSpitfire = 45000, 2. HawkerHurricane = 30000, 3. SpaceGlider = 15000 ");

            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {

                        return SupermarineSpitFire(); //return the new values of the variable in MainCharacter class

                    }
                case ConsoleKey.D2:
                    {

                        return HawkerHurricane();


                    }
                case ConsoleKey.D3:
                    {

                        return SpaceGlider();


                    }
                default:
                    return SpaceGlider(); // to anything
            }



        }

       

        public  (double, double, double, int, string) SupermarineSpitFire()  // calling the variable from the character class and using sums. then returning the new value.
        {
            character1.warpSpeed += 9;
            character1.shillings -= 45000;
            character1.fuel += 300;
            character1.storage +=  150;
            character1.shipName = "Supermarine SpitFire";
            return (character1.shillings, character1.fuel, character1.storage, character1.warpSpeed, character1.shipName); 
        }


        public (double, double, double, int, string) HawkerHurricane()
        {
            character1.warpSpeed += 6;
            character1.shillings -= 30000;
            character1.fuel += 200;
            character1.storage += 150;
            character1.shipName = "Hawker Hurricane";
            return (character1.shillings, character1.fuel, character1.storage, character1.warpSpeed, character1.shipName);

        }

        public (double, double, double, int, string) SpaceGlider()
        {
            character1.warpSpeed += 4;
            character1.shillings -= 15000;
            character1.fuel += 150;
            character1.storage += 100;
            character1.shipName = "Space Glider";
            return (character1.shillings, character1.fuel, character1.storage, character1.warpSpeed, character1.shipName);

        }
        
       

    }

        
    }

