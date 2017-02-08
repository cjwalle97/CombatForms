using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
        //private Stat Health;
        //private Stat Mana;
        //private Stat Strength;
        //private Stat Magic;
        //private Stat Dexterity;
        //private Stat Agility;
        //private Stat Luck;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private bool Alive;

        public Player() { }
        public Player(string n,/* Stat h, Stat e, Stat s, Stat m, Stat d, Stat a, Stat l*/, Element w, Element r, Element t)
        {
            Name = n; //Health = h; Mana = e;
            //Strength = s; Magic = m; Dexterity = d;
            //Agility = a; Luck = l;
            Weakness = w; Resistance = r; AttackType = t;
        }
        void IDamageable.Damage(int damage)
        {

        }
        
    }

    //Name: Demon
    //Type: Class
    class Demon : Player, IDamageable
    {
        private string Name;
        //private int Strength;
        //private int Magic;
        //private int Dexterity;
        //private int Agility;
        //private int Luck;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private Player Summoner;

        public Demon() { }
        public Demon(string n, int s, int m, int d, int a, int l, Element w, Element r, Element t, Player o)
        {
            Name = n; //Strength = s; Magic = m;
            //Dexterity = d; Agility = a; Luck = l;
            Weakness = w; Resistance = r; AttackType = t;
            Summoner = o;
        }
        
    }
}
