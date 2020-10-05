using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class QuestItems: Item
    {
        public int ID { get; set; }

        public QuestItems(string name, string description, int id)
            :base(name, description)
        {
            ID = id;
        }

       
    }
}
