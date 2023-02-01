using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask
{
    internal abstract class HouseHold_Technology
    {
        public string Brand;
        public double Weight;
        protected double _electricityConsumption;

        public double ElectricityConsumption
        {
            set { _electricityConsumption = value;}
            get=> _electricityConsumption; 
        }
          


        public abstract void UseFor();

        protected int _electricPower;

        public void ElectConsump(int time)
        {
           ElectricityConsumption = _electricPower*time;
        }

    }
}
