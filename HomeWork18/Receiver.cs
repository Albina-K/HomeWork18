using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18
{
    class Receiver
    {
        public string adress;

        public Receiver(string adress)
        {
            this.adress = adress;
        }

        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }
    }
}
