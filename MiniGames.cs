using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class MiniGames
    {
        public static void FirstInteraction()
        {
            Console.Write("1. peek out head and look at car.         | |         2. stay hidden.");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            Console.Clear();
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("\n" + "\n" + "sees car");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Write("\n" + "\n" + "good idea, but you should have looked");
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    }
            }
        }


            public static void OpenScuttleAttic()
            {
            Console.Write(new string('\n', 5));
            Console.Write(" Press [1] to pull on door"); 
                ConsoleKeyInfo cki1;
                cki1 = Console.ReadKey(true);
                Console.Clear();
                switch (cki1.Key)
                {
                    case ConsoleKey.D1:
                    {
                        int i;
                        for (i = 0 ; i < 9; i++)
                        {
                            Console.Write("\n" + "\n" + "[ENTER] to Pull Harder");
                            Console.ReadLine();                         
                            i++;    
                        }
                            Console.Clear();
                            break;
                        }
                  
                }

            }


        public static void SaveXerqril()
        {
                Console.Write(new string('\n', 5));
                Console.Write(" Press [1] to pull on door");
                ConsoleKeyInfo cki1;
                cki1 = Console.ReadKey(true);
                Console.Clear();
                switch (cki1.Key)
                {
                    case ConsoleKey.D1:
                        {
                            int i;
                            for (i = 0; i < 9; i++)
                            {
                                Console.Write("\n" + "\n" + "[ENTER] to Pull Harder");
                                Console.ReadLine();
                                i++;
                            }
                            Console.Clear();
                            break;
                        }

                }

            }



        }

    }


