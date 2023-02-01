using System;
using System.Collections.Generic;
using System.Text;

namespace _31._01_Homeworks
{
    internal class Bicycle:Vehicle
    {

        public override void Drive(int km)
        {
            Mileage+=km;
        }
    }
}
