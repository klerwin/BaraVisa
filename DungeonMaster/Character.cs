using System;
namespace DungeonMaster
{
    public class Character
    {
        public enum CharClass{

            None,
            Wizard,
            Knight,
            Paladin,
            Archer,
        }

        public enum StatPoints{

            None,
            Hp,
            Attack,
            Defense,
            Dexterity,
            Wisdom,
        }
        
        public string Name { get; set; }
        public CharClass ClassType { get; set; }
        public StatPoints HpId { get; set; }
        public StatPoints AtkId { get; set; }
        public StatPoints DefId { get; set; }
        public StatPoints DexId { get; set; }
        public StatPoints WisId { get; set; }

        public Character(string name, CharClass classType,
            StatPoints hpId,
            StatPoints atkId,
            StatPoints defId,
            StatPoints dexId,
            StatPoints wisId)
        {
            Name = name;
            ClassType = classType;
            HpId = hpId;
            AtkId = atkId;
            DefId = defId;
            DexId = dexId;
            WisId = wisId;

        }
    }
}
