using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Stats
    {
        private float HP;
        private float MP;
        private float STR;
        private float MAG;
        private float DEX;
        private float AGI;
        private float LUC;

        public Stats(float h, float m, float s, float i, float d, float a, float l) {
            HP = h; MP = m; STR = s; MAG = i; DEX = d; AGI = a; LUC = l;
        }
        //Name: TakeDamage
        //Type: void
        //Description subtacts a float from HP
        public void TakeDamage(float damage)
        {
            HP -= damage;
        }
    }
}
