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
        void Damage(float damage);
    }
    //Name: ISkill
    //Type: Interface
    //Description: 
    interface ISkill<T>
    {
        void SkillTarget(T target);
    }
    //Name: ICastSkills
    //Type: interface
    //Description: allows Players and Demon's to to cast skills 
    //interface ICastSkills<T>
    //{
    //    List<T> SkillList();
    //}

    //class Skill : ISkill
    //{
    //    private string Name;
    //    private Element Type;
    //    private Player PlayerTarget;
    //    private Demon DemonTarget;

    //    public Skill() { }
    //    public Skill(string n, Element t)
    //    {
    //        Name = n; Type = t;
    //    }
    //    void ISkill.SkillTargetPlayer(Player target)
    //    {
    //        PlayerTarget = target;
    //    }
    //    void ISkill.SkillTargetDemon(Demon target)
    //    {
    //        DemonTarget = target;
    //    }
    //}

    class Agi<T> : ISkill<T>
    {
        private string Name = "Agi";
        private float Cost = 8;
        private Element Type = 0;
        private T Target;

        public Agi() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class Bufu<T>: ISkill<T>
    {
        private string Name = "Bufu";
        private float Cost = 8;
        private Element Type 1;
        private T Target;

        public Bufu() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target
        }
    }
}
