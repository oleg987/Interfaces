using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Phone : ISmsSender, IEmailSender
    {
        void ISmsSender.Send()
        {
            Console.WriteLine("sms");
        }

        void IEmailSender.Send()
        {
            Console.WriteLine("email");
        }

        //public void Send()
        //{
        //    Console.WriteLine("call");
        //}
    }
}
