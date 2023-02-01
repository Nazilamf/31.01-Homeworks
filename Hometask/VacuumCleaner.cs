using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask
{
    internal class VacuumCleaner : HouseHold_Technology,IEnergy
    {
        int time;
        int IEnergy.ElectricPower { get => _electricPower; set => _electricPower= value; }
        int IEnergy.Time { get => time; set => time = value; }

        public override void UseFor()
        {
            Console.WriteLine("used to clean home");
        }
    }
}
