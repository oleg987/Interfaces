using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class FlyByWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("fly by wings");
        }

        public void Move()
        {
            Console.WriteLine("move");
        }
    }
}
