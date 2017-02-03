using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    //Name: Element
    //Type: enum
    //Description: determines what element a Skill/Attack is, should a 
    public enum Element
    {
        Fire = 0,
        Ice = 1,
        Electricity = 2,
        Force = 3,
        Dark = 4,
        Light = 5,
        Slash = 6,
        Pierce = 7,
        Bash= 8,
    }
    //Name: Player
    //Type: Class
    class Player : IDamageable
    {
        private string Name;
        private int Health;
        private int Mana;
        private int Strength;
        private int Magic;
        private int Dexterity;
        private int Agility;
        private int Luck;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private bool Alive;

        public Player() { }
        public Player(string n, int h, int e, int s, int m, int d, int a, int l, Element w, Element r, Element t)
        {
            Name = n; Health = h; Mana = e;
            Strength = s; Magic = m; Dexterity = d;
            Agility = a; Luck = l;
            Weakness = w; Resistance = r; AttackType = t;
        }
        //Name: TakeDamage
        //Type: Void
        //Description: when invoked will cause the Player to take damage
        public void Damage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Alive = false;
            }
        }
    }

    //Name: Demon
    //Type: Class
    class Demon //: IDamageable
    {
        private string Name;
        private int Strength;
        private int Magic;
        private int Dexterity;
        private int Agility;
        private int Luck;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private Player Summoner;

        public Demon() { }
        public Demon(string n, int s, int m, int d, int a, int l, Element w, Element r, Element t, Player o)
        {
            Name = n; Strength = s; Magic = m;
            Dexterity = d; Agility = a; Luck = l;
            Weakness = w; Resistance = r; AttackType = t;
            Summoner = o;
        }
    }
}
