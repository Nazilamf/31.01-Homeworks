using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _31._01_Homeworks
{
    internal class Student
    {
        public int No;
        public string FullName;
        public byte Point;

        static private int _totalCount;
        
        static Student()
        {
            _totalCount = 100;
        }

        public Student() 
        {
            _totalCount++;
            No = _totalCount;
        }



    }
}
