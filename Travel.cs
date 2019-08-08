using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class Travel

    {
        //int fuel;
        //int distace;
        //int speed;
        //int age;
        // warp speed factor
        
        public static void WarpSpeed()
        {         
            // insert formula into console.keys
            // velocity = 10(10^3) + (10-W)(-11/3) multiply by 362.25 to get days. w = hyperspeed setting.
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);

            Console.Write("");
            Console.WriteLine("");

            switch (cki.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.D2:
                    {
                        int distanceFormula = 2 ^ (10 / 3) + (10 - 2) ^ (-11 / 3);
                        double travelTime = 24800000000 / distanceFormula * 362.25;
                        // 33 days
                        Console.Write(travelTime);
                        break;
                    }

                //case ConsoleKey.D3:
                //case ConsoleKey.D4:
                //case ConsoleKey.D5:
                //    {
                //        int w = 5;
                //        /*distance to planet divided */
                //        distanceFormula /* *362.25*/;
                //        break;
                //    }

                //case ConsoleKey.D6:
                //case ConsoleKey.D7:
                //    {
                //        int w = 7;
                //        /*distance to planet divided */
                //        distanceFormula /* *362.25*/);
                //        break;
                //    }

                case ConsoleKey.D8:
                case ConsoleKey.D9:
                    {
                        int distanceFormula = 9 ^ (10 / 3) + (10 - 9) ^ (-11 / 3);
                        double travelTime = 24800000000 / distanceFormula * 362.25;

                        Console.Write(travelTime);
                        break;
                    }



            } }



                    //            Console.WriteLine(distanceFormula /* distance*/ );  //planet.earth for distance

                    //    }
                    //}
                    
                    public static double WarpFormula( double warpSpeed, double distance)
                    { 
                        Double distanceFormula = Math.Pow(warpSpeed,10 / 3) + Math.Pow(10-warpSpeed,-11 / 3);
                        double timeTravel = (distance / distanceFormula) * 362.25;
            Console.WriteLine(timeTravel);
            Console.ReadKey();
                        return timeTravel;

                    }
       
        }





            }
        
    

