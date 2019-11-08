using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck(new FlyByWings(), new Quack());
            duck.Fly();
            duck.Swim();
            duck.Quack();

            Console.WriteLine();

            Duck duck1 = new RubberDuck(new FlyNoWay(), new Squick());
            duck1.Fly();
            duck1.Swim();
            duck1.Quack();

            Console.WriteLine();

            Duck duck2 = new DecorDuck(new FlyNoWay(), new MuteQuack());
            duck2.ChangeFlyBehavior(new RocketFly());
            duck2.Fly();
            duck2.Swim();
            duck2.Quack();

            Console.WriteLine();

            FlyByWings fly = new FlyByWings();

            IFlyBehavior fly1 = (IFlyBehavior)fly;

            SwimAndFly swimAndFly = new SwimAndFly();
            swimAndFly.Swim();
            swimAndFly.Fly();

            IFlyBehavior fly2 = (IFlyBehavior)swimAndFly;

            ISwimBehavior swim = (ISwimBehavior)swimAndFly;

            Phone phone = new Phone();

            ((IEmailSender)phone).Send();
            ((ISmsSender)phone).Send();           


        }
    }
}
