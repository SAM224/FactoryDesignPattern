using System;

namespace SimpleFactory.Autos
{
    class BMW335Xi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("BMW335Xi is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW335Xi is off.");
        }
    }
}