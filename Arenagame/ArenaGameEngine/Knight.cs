using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
   
    public class Knight : Hero
    {
        public Knight() : this("Sir John")
        {

        }

        public Knight(string name) : base(name) 
        {
            hitCount = 0;
        }

        private int hitCount;

        public override int Attack()
        {
            hitCount = hitCount + 1;
            int baseAttack = base.Attack();
            if (hitCount == 5)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int coef = Random.Shared.Next(20, 61);
            incomingDamage = incomingDamage - (coef * incomingDamage) / 100;
            base.TakeDamage(incomingDamage);
        }
    }
}
