using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Student
    {
        public int No;
        public string Name;
        public string Group;

        static private int _totalCount;
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }


        static public bool CheckGroupNo(string group)
        {
            if (string.IsNullOrWhiteSpace(group))
            {
                return false;
            }
               

            if (!char.IsUpper(group[0]) || !(group.Length == 4) ||!char.IsDigit(group[1]) || !char.IsDigit(group[2]) || !char.IsDigit(group[3]))
            {
                return false;
            }
            return true;
        }
    }
}
