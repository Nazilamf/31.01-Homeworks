using System;
using System.Collections.Generic;
using System.Text;

namespace _31._01_Homeworks
{
    internal class Car:Vehicle
    {
        public double CurrentFuel;
        public double FuelFor1Km;

        public override void Drive(int km)
        {
            Mileage +=km;
            CurrentFuel -= km*FuelFor1Km;
        }
    }
}
