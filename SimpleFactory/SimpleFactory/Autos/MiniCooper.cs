using System;

namespace SimpleFactory.Autos
{
    class MiniCooper : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("MiniCooper is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("MiniCooper is off.");
        }
    }
}