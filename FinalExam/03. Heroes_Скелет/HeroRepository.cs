using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> listOfHeros;

        public int Count
        {
            get
            {
                return listOfHeros.Count;
            }

        }
        public HeroRepository()
        {
            this.listOfHeros = new List<Hero>();
        }
        public void Add(Hero hero)
        {
            listOfHeros.Add(hero);
        }

        public void Remove(string name)
        {
            var index = listOfHeros.FindIndex(x => x.Name == name);
            listOfHeros.RemoveAt(index);
            //return listOfHeros.Count;
        }

        public Hero GetHeroWithHighestStrength()
        {
            int maxStrengh = 0;
            int indexMaxStrengh = 0;
            for (int i = 0; i < listOfHeros.Count; i++)
            {
                if (listOfHeros[i].Item.Strength > maxStrengh)
                {
                    maxStrengh = listOfHeros[i].Item.Strength;
                    indexMaxStrengh = i;
                }
            }
            return listOfHeros[indexMaxStrengh];
        }

        public Hero GetHeroWithHighestAbility()
        {
            int maxStrengh = 0;
            int indexMaxStrengh = 0;
            for (int i = 0; i < listOfHeros.Count; i++)
            {
                if (listOfHeros[i].Item.Ability > maxStrengh)
                {
                    maxStrengh = listOfHeros[i].Item.Ability;
                    indexMaxStrengh = i;
                }
            }
            return listOfHeros[indexMaxStrengh];
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int maxStrengh = 0;
            int indexMaxStrengh = 0;
            for (int i = 0; i < listOfHeros.Count; i++)
            {
                if (listOfHeros[i].Item.Intelligence > maxStrengh)
                {
                    maxStrengh = listOfHeros[i].Item.Intelligence;
                    indexMaxStrengh = i;
                }
            }
            return listOfHeros[indexMaxStrengh];
        }

        public override string ToString()
        {
            string result = null;
            foreach (var currentHero in listOfHeros)
            {
                result += $"Hero: {currentHero.Name} – {currentHero.Level}lvl\n";
                result += $"Item:\n";
                result += $"  * Strength: {currentHero.Item.Strength}\n";
                result += $"  * Ability: {currentHero.Item.Ability} \n";
                result += $"  * Intelligence: {currentHero.Item.Intelligence}\n";

            }


            return result;

        }
    }
}
