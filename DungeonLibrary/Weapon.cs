using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon : Item
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set

        }//end MinDamage

        public Weapon(string name, string description, int maxDamage, int bonusHitchance, bool isTwoHanded, int minDamage)
            :base (name, description)
        {
            Name = name;
            Description = description;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitchance;
            IsTwoHanded = isTwoHanded;
            MinDamage = minDamage;
        }

       

        public override string ToString()
        {
            return string.Format("Name: {0}\n{1} to {2} damage\nHit Modifier: {3}%\n{4} ",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                IsTwoHanded ? "This " + Name + " requires both hands." : "This " + Name +  " only requires one hand"
                );
        }

       

    }//end class
}//end namespace
