using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    class Еsquire: Hero
    {
        //- Has armor, which reduces the incoming damage between 40 and 60%.
        //- Every 2 hits can deal damage - a random number between 1 and 3

        public Еsquire() : this("Sir") //By default, all esquires are named 'Sir'
        {

        }

        public Еsquire(string name) : base(name) //A named esquire, we supply the name
        {
            hitCount = 0;
        }

        private int hitCount;

        public override int Attack()
        {
            hitCount = hitCount + 1;
            int baseAttack = base.Attack();
            if (hitCount == 2)
            {
                int rev = Random.Shared.Next(1, 4);
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(40, 60);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
