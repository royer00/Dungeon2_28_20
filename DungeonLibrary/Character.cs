using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Character
    {
        private int _life;
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int XP { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }//end set
        }//end life



        //Even though we won't be making Character Objects, we want a CTOR to use as a foundation for child classes
        public Character(string name, int hitChance, int block, int maxLife, int life, int xp)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
            XP = xp;
        }

        //Because we want different outputs for the Player and the Monster classes, we will not write a ToString() here.

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        //Because we have no way to calculate the damage in this class but both child classes will need to be able to do so, we will create some base functionality here that we will override in each child
        public virtual int CalcDamage()
        {
            return 0;
        }

    }//end class
}//end namespace
