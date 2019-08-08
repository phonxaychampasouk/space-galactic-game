using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class StoryLine
    {

        
        public static void MainStoryLine()
        {
            //RandomeCharacter randomCharacter = new RandomeCharacter();
            //randomCharacter.CharacterRandom(); 
            /*Create Generator for Race, Age, and Birth Place*/
            Console.WriteLine("Prison Guard: What is your name?" + "\n");
            string characterName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Prison Guard: NOPE NOT ANYMORE! You are the governments property. Your new name is 988!" + "\n" + "\n");
            Console.WriteLine($"988: :'(");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"It's the year 4988 and universe is unstable. There is no supreme ruler or governing body within" +
            $" the relms of our galaxies. Space dwellers from the most remote parts of the universe" +
            $" have joined forces to destroy all of those who do not comply with their beliefs. The Space Dwellers " +
            $" overall goal is to monoplolize all available nature resourses in the universe to control EVERYTHINGGGGG." + "\n" + "\n" +
            $" ");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Cling, cling, cling, zip, zap...... " + "\n" + "\n" +
                              $"988: I guess its time to get up, the guards are already tapping the cell bars with their plasma" +
                              $" swords. " + "\n" + "\n" +
                              $"Prison Guards: GET UP FAIRIES, RISE AND SHINE");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"(Fast Forward to Space Yard)" + "\n" + "\n" +
                              $"988: Why am I here? I was just a Space Cadet going to Space School when these Space Neanderthals" +
                              $" raided my space cafeteria while i was having my space lunch!" + "\n" + "\n" +
                              $"Prison Guard: Alright, space yard time is over, time to hit the space showers and go to space bed!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"(Fast Forward to 988's cell.) " + "\n" + "\n" +
                              $" Pssssh. Psssh. Hey Human..." + "\n" + "\n" +
                              $"988: My names 988, what do you want Xerqril? " + "\n" + "\n" +
                              $" Xerqril: I am planning on escaping this Number 2 hole tonight. Will you help me out?" + "\n" + "\n" +
                              $"988: When do I start?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"(Fast Forward to outside perimeter of the JailHouse. )" + "\n" + "\n" +
                              $"Xerqril: 3, 2, 1... See I told you if I reversed the spurting bearings with the panametric fans the electrical fence would short circuit! " + "\n" + "\n" +
                              $"988: Great! You're a genius. Now lets get over this fence and get as far away as possible before we get caught!" + "\n" + "\n" +
                              $"Xerqril: Right! Lets go! ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"988: You hear that?! It sounds like there are vehicles coming our way! Get Down!" + "\n" + "\n" +
                              $"Xerqril: Wait why?! We could ask them for directions!" + "\n" + "\n" +
                              $"988: No you Idiot! Look what you are wearing. It clearly states that you are Prisoner 182 and I am Prisoner 988." +
                              $" We have escaped jail yes but remember we are now fugitives to this world! They must be looking for us by now so we have to lay low!");
            Console.ReadLine();
            Console.Clear();
            Console.Write(new string('\n', 5));


            MiniGames.FirstInteraction();


            Console.WriteLine( " The duo have been walking for hours now, they are feeling the affects of Solar explosure and dehydration. They must find some a place to rest before they calapse. ");
            Console.Write(new string('\n', 5));
            Console.WriteLine("Xerqril: Look! This mechanic shop door is unlocked. Lets look inside, they must have a set of overalls we can change into." + "\n" + "\n" +
                      $" 988: Thats smart, They'll probably have food and beer in the fridge. Its been over a year sense Ive tasted beer." +
                      $"We'll also lay low somewhere in this shop. Hey Xerqril look for a door to the scuttle attic. We'll hide out in there until the morning.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Xerqril: Look I found the door to the attic, I'll start heading up there now and catch some sleep." + "\n" + "\n" +
                              $"988: That's a good idea. I'll be up in a second after I make sure everything is put back to how we found it.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"(Xerqril opens up attic door and proceeds to climb up)");


            MiniGames.OpenScuttleAttic();


            Console.WriteLine($" uhhhh....988.. can you come over here?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Man With Monkey Wrench: What the hell are you doing trying to get into my Attic?!" + "\n" + "\n" +
                              $"988: I will tell you if you release that monkey wrench from my friends throat." + "\n" + "\n" +
                              $"Xerqril: IM NOT SCARED OF THIS GUY! Ill get out of this dont worry just be ready 988!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Man with Monkey Wrench: You have 10 seconds before I kill this guy, Explain yourself!" + "\n" + "\n" +
                              $" 988: Hold up man, You can see I am a HUMAN. Why would I be on this forsaken planet?! I was enslaved by the Neanderthals and forced to 4 eternities of hard labor! Im a Space Cadet  who........" + "\n" + "\n" +
                              $"Man with Monkey Wrench:(Interrupts 988) You say Space Cadet? I dont believe it! Space Cadets are our only hope to saving our universe! Now your friend is going to DIEEEE!+" + "\n" + "\n" +
                              $"");

            SaveXerqril();
         
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It's been 2 year since that first encounter. Jefry is now a intermediate mechanic and knows his way around the shop. Xerquil left about a month in their hide out, without leaving a word" +
                ", he is long forgotten. ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Jefry: Ahron?");
            Console.Write(new string('\n', 5));
            Console.Write("Ahron: Jefry?" + "\n" + "\n" +
                              "Jefry: You know I cant stay here forever." + "\n" + "\n" +
                              "Ahron: I know that and I also dont want you too."); 
            Console.ReadLine();
            Console.Clear();

            Console.Write(new string('\n', 5));
            StayOrGo();

            Console.ReadLine();
            Console.Write(new string('\n', 5));
            Console.Clear();
            Console.WriteLine("Ahrom dies and a 7 eye child finds Jefry in town and informs him that his grandpa dies" +
                         "Jefrey goes back to shop and plays the part of Ahrons grandson and inherits shop, a parted out inter galactic space pod along with Ahrons");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("With 60,000 shillings, a small shop, the keys to a gutted out inter planetary SpaceShip");
            
        }
    



    public static void SaveXerqril()
    {
        Console.Write(new string('\n', 5));
        Console.WriteLine("You must save Xerquil, You must think quickly, what will you do?      1.  | 2.   | 3.   ");
        ConsoleKeyInfo cki;
        cki = Console.ReadKey(true);
        switch (cki.Key)
        {
            case ConsoleKey.D1:
                {
                        Console.Write(new string('\n', 10));
                        Console.WriteLine(" 1 = 988 stands at the position of space attention and recites The Space Cadets Creed");
                        Console.ReadLine();
                    Console.Clear();

                    break;
                }
            case ConsoleKey.D2:
                {
                        Console.Write(new string('\n', 10));
                        Console.WriteLine("2 = Space Cadet breaks down and shreeks to let his friend go!");
                        Console.ReadLine();
                        Console.Clear();
                    break;
                }
            case ConsoleKey.D3:
                {
                        Console.Write(new string('\n', 10));
                        Console.WriteLine("3 = Space Cadet leaps at Man and successfully apprehends monkey wrench.");
                        Console.ReadLine();
                        Console.Clear();
     
                    break;
                }
            default:
                    Console.Write(new string('\n', 10));
                    Console.WriteLine("3 = Space Cadet leaps at Man and successfully apprehends monkey wrench.");
                    Console.ReadLine();
                    Console.Clear();

                    return; 
             
                }

        }
       
     
        
    


        static void StayOrGo()
        {
        Console.Write(new string('\n', 5));
            Console.WriteLine("1 = Stay, asks Ahron to use his shop to build a ship durable enough to travel to his home planet.Ahron says he cant use his shop because it is too small and he must go and find his own.");
            Console.Write(new string('\n', 10));
            Console.WriteLine("2 = Go, Jefry says Right, My stuff is packed and Ill be leaving at first space rooster crow. It was nice knowing you ");
   
            }
       
            

    }
       
        }

        
  







