using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    class Warrior : Hero
    {
        // No Defense: incoming damage between 50 and 100%.
        // Every 3 hits can deal double damage.
        public Warrior() : this("Ivan") //By default, all warrior are named 'Ivan'
        {

        }

        public Warrior(string name) : base(name) //A named warrior, we supply the name
        {
            hitCount = 0;
        }

        private int hitCount;

        public override int Attack()
        {
            hitCount = hitCount + 1;
            int baseAttack = base.Attack();
            if (hitCount == 3)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(50, 100);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
