using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Potion : Item
        {
        

        public Potion(string name, string description)
            :base(name, description)
        {
           
           

        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}");
        }

        public virtual void UsePotion(Player player)
        {
            
        }
    }
}
