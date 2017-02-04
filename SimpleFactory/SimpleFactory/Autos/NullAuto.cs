using System;

namespace SimpleFactory.Autos
{
    internal class NullAuto : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("NullAuto is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("NullAuto is off.");
        }
    }
}