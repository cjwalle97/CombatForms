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
        void SkillTargetPlayer(Player<T> target);

        void SkillTargetDemon(Demon<T> target);
    }
    //Name: ICastSkills
    //Type: interface
    //Description: allows Players and Demon's to to cast skills 
    interface ICastSkills<T>
    {
        List<T> SkillList();
    }

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

    //class Agi : ISkill<T>
    //{
    //    private string Name = "Agi";
    //    private Element Type = 0;

    //    public Agi() { }
    //    void ISkill.SkillTarget(Player<T> target)
    //    {

    //    }
    //    public void Damage
} 
