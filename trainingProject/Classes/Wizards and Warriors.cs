using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    abstract class Character
    {
        bool isVulnerable;
        string charType;

        protected Character(string characterType)
        {
            isVulnerable = false;
            charType = characterType;
        }

        public abstract int DamagePoints(Character target);

        public virtual bool Vulnerable()
            => isVulnerable;

        public override string ToString()
            =>$"Character is a {this.GetType().Name}";
    }

    class Warrior : Character
    {
        public Warrior() : base("Warrior")
        {
        }

        public override int DamagePoints(Character target)
            => target.Vulnerable() ? 10 : 6;
    }

    class Wizard : Character
    {
        bool spellPrepared;

        public Wizard() : base("Wizard")
        {
            spellPrepared = false;
        }

        public override int DamagePoints(Character target)
            => spellPrepared ? 12 : 3;

        public void PrepareSpell()
        {
            spellPrepared = true;
        }

        public override bool Vulnerable()
            => !spellPrepared;
            
    }
}
