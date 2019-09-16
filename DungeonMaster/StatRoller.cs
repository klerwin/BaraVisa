using System;
namespace DungeonMaster
{
    public class StatRoller
    {
        public int RandomHp { get; set; }
        public int RandomAtk { get; set; }
        public int RandomDef { get; set; }
        public int RandomDex { get; set; }
        public int RandomWis { get; set; }

        public StatRoller()
        {
            bool roller = true;
            while (roller == true)
            {
                Random hp = new Random();
                RandomHp = hp.Next(90, 121);
                Random atk = new Random();
                RandomAtk = atk.Next(19, 26);
                Random def = new Random();
                RandomDef = def.Next(19, 26);
                Random dex = new Random();
                RandomDex = dex.Next(19, 26);
                Random wis = new Random();
                RandomWis = wis.Next(19, 26);
                break;
            } 
        }

        public void DisplayStats()
        {
            StatRoller myStats = new StatRoller();
            {
                Console.WriteLine();
            }








        }
    }

}
