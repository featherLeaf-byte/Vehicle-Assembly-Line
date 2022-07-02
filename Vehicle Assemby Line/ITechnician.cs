using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    interface ITechnician
    {
        void Attach(IVehicle Observer);
        void Detach(IVehicle Observer);
        void Notify();
    }
}
