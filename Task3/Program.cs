using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Student st1 = new Student();
            Student st2 = new Student();


            Console.WriteLine(st2.No);

            string group;
            do
            {
                Console.WriteLine("Group No daxil edin");
                group = Console.ReadLine();

            } while (!Student.CheckGroupNo(group));
            

        }
    }
}
