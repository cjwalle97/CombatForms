using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public enum Element
    {
        0 = Fire,
        1 = Ice,
        2 = Electricity,
        3 = Force,
        4 = Dark,
        5 = Light,
        6 = Slash,
        7 = Pierce,
        8 = Bash,
    }
    class Player : IDamagable
    {
        private int Health;
        private int Mana;
        private int Strength;
        private int Magic;
        private int Dexterity;
        private int Agility;
        private int Luck;
        private Element Weakness;
        private Element Resistance;


    }
}
