using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    interface IDamagable
    {
        void Damage(float);
    }
    interface ISkill
    {
        void Name(string);
        void Damage(int);
    }
}
