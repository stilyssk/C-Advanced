using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        private int ability;
        private int intelligence;
        private int strength;
        public Item(int strength, int ability, int intelligence)
        {
            this.Ability = ability;
            this.Intelligence = intelligence;
            this.Strength = strength;
        }
        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public int Ability
        {
            get { return this.ability; }
            set { this.ability = value; }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set { this.intelligence = value; }
        }

        public override string ToString()
        {
            string result = null;
            result += "Item:\n";
            result += $"  *  Strength: {this.Strength}\n";
            result += $"  *  Ability: {this.Ability}\n";
            result += $"  *  Intelligence: {this.Intelligence}";
            return result;
        }
    }
}
