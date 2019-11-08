using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SwimOnWater : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Swim on water");
        }
    }
}
