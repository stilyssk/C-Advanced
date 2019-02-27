using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        private string name;
        private int level;
        private Item item;
        public Hero(string name, int level,Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }
        public Item Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            string result = null;
            result += $"Hero: {this.Name} – {this.Level}lvl\n";
            result += " Item:\n";
            result += $"  *  Strength: {this.Item.Strength}\n";
            result += $"  *  Ability: {this.Item.Ability}\n";
            result += $"  *  Intelligence: {this.Item.Intelligence}";
            return result;
        }

    }
}
