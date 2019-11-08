using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehavior fly1, IQuackBehavior quack) : base(fly1, quack)
        {
        }

    }
}
