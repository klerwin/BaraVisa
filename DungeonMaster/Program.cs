using System;

namespace DungeonMaster
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Dungeon Master! \n");
                Console.WriteLine("*****MAIN MENU***** \n");
                Console.WriteLine("(1) Add Character");
                Console.WriteLine("(2) Remove Character");
                Console.WriteLine("(3) Check Party");
                Console.WriteLine("(4) Enter Realm");
                Console.WriteLine("(5) Exit \n");

                int menuInput = Convert.ToInt32(Console.ReadLine());

                switch (menuInput)
                {

                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.Clear();
                        Party myParty = new Party();
                        myParty.DisplayParty();
                        string menuReturn;
                        Console.WriteLine("Return to main menu?");
                        menuReturn = Console.ReadLine();
                        if (menuReturn == "Y")
                        {
                            break;
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Thank you for playing!");
                        Environment.Exit(0);
                        
                        break;


                    default:
                        break;
                }

            } while (true);
        }
    }
}
