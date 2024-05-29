using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.Hotel.API
{
    interface IShow
    {
        void Show();
    }
    interface IShow_Case
    {
        void Show();
    }
    class B : IShow, IShow_Case
    {
        /*public B(int a)
        {

        }*/

        void IShow.Show()
        {
            Console.WriteLine("IShow Interface function");
        }

        void IShow_Case.Show()
        {
            Console.WriteLine("IShow_Case Interface function");
        }

        static void Main(string[] args)

        {
            IShow I = new B();
            I.Show();
            IShow_Case I1 = new B();
            I1.Show();

            //B b = new B();
            //b.Show();

            Console.ReadKey(true);
        }
    }
}
