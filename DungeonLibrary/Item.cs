﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Item( string name, string description)
        {
            Name = name;
            Description = description;
        
        }
        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}");
        }
    }
}
