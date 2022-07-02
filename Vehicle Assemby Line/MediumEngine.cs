using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class MediumEngine:IEngineBehaviour
    {
        public void Engine()
        {
            Console.WriteLine("Medium Engine");
        }
    }
}
