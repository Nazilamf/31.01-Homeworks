using System;
using System.Threading;

namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            WashingMatchine wm = new WashingMatchine
            {
                Brand ="Bosch",
                Weight = 25
            }  ;          
            
            wm.UseFor();


            VacuumCleaner vc = new VacuumCleaner
            {
                Brand ="Samsung",
                Weight = 10
            };



            vc.UseFor();
        }

        
    }
}

