using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonMaster
{

    public class Party

    {
        public static List<Character> PartyList { get; set; }

        public Party()
        {
            PartyList = new List<Character>();

            PartyList.Add(new Character("Fizzik", Character.CharClass.Wizard,
                Character.StatPoints.Hp,
                Character.StatPoints.Attack,
                Character.StatPoints.Defense,
                Character.StatPoints.Dexterity,
                Character.StatPoints.Wisdom));

            PartyList.Add(new Character("Greta", Character.CharClass.Paladin,
                Character.StatPoints.Hp,
                Character.StatPoints.Attack,
                Character.StatPoints.Defense,
                Character.StatPoints.Dexterity,
                Character.StatPoints.Wisdom));
        }
        public void DisplayParty()
        {
                Party myParty = new Party();

                foreach (var item in Party.PartyList)
                {
                StatRoller myStats = new StatRoller();
                myStats.DisplayStats();

                Console.WriteLine($"Name: {item.Name}\nClass: {item.ClassType}\n" +
                        $"\n{item.HpId}: {myStats.RandomHp}\n" +
                        $"{item.AtkId}: {myStats.RandomAtk}\n" +
                        $"{item.DefId}: {myStats.RandomDef}\n" +
                        $"{item.DexId}: {myStats.RandomDex}\n" +
                        $"{item.WisId}: {myStats.RandomWis}\n");
                }
        }
    } 
    
}

    