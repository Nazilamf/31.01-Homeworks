using System;
using System.Collections.Generic;
using System.Text;

namespace _31._01_Homeworks
{
    internal abstract class Vehicle
    {
        private double _mileage;



        public double Mileage
        {
            set { _mileage = value; }   
                
            get=> _mileage; 

        }

        public abstract void Drive(int km);
       

    }
}
