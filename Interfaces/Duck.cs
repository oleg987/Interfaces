using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Duck
    {
        IFlyBehavior fly;
        IQuackBehavior quack;
        ISwimBehavior swim;

        public IFlyBehavior Fly1 { get => fly; set => fly = value; }
        public IQuackBehavior Quack1 { get => quack; set => quack = value; }
        public ISwimBehavior Swim1 { get => swim; set => swim = value; }

        public Duck(IFlyBehavior fly1, IQuackBehavior quack)
        {
            Fly1 = fly1;
            Quack1 = quack;
            Swim1 = new SwimOnWater();
        }

        public virtual void Fly()
        {
            fly.Fly();
        }

        public virtual void Swim()
        {
            swim.Swim();
        }

        public virtual void Quack()
        {
            quack.Quack();
        }

        public virtual void ChangeFlyBehavior(IFlyBehavior flyBehavior)
        {
            Fly1 = flyBehavior;
        }
    }
}
