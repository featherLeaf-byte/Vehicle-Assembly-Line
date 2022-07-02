using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class SmallEngine:IEngineBehaviour
    {
        public void Engine()
        {
            Console.WriteLine("Small Engine");
        }
    }
}
