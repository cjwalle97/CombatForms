using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Stats 
    {
        public int Health;
        public int Mana;
        public float Strength;
        public float Magic;
        public float Dexterity;
        public float Agility;
        public float Luck;

        public Stats(int h, int m, int s, int i, int d, int a, int l) {
            Health = h; Mana = m; Strength = s; Magic = i; Dexterity = d; Agility = a; Luck = l;
        }
        //Name: TakeDamage
        //Type: void
        //Description: subtracts a float from Health
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        //Name: PayCost
        //Type: void
        //Description: subtracts a float from Mana 
        public void PayCost(int cost)
        {
            Mana -= cost;
        }
    }
}
