using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SwimAndFly : ISwimBehavior, IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Swim(fly)");
        }

        public void Swim()
        {
            Console.WriteLine("fly(swim)");
        }
    }
}
