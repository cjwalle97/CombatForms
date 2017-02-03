using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    //Name: IDamagable
    //Type: Interface
    //Description: allows the Players and Demons to take damage
    public interface IDamageable
    {
        void Damage(int damage);
    }
    //Name: ISkill
    //Type: Interface
    //Description: 
    interface ISkill
    {
        string Name(string name);
        int Damage(int Ow);
    }
}
