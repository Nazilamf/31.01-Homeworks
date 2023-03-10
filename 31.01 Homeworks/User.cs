using System;
using System.Collections.Generic;
using System.Text;

namespace _31._01_Homeworks
{
    internal class User
    {
        public string UserName;
        private string _password;

        public string Password
        {
            set
            {
                if(CheckPassword(value))
                    _password = value;
            }
           
            
        }
        static public bool CheckPassword(string str)
        {

            if (string.IsNullOrWhiteSpace(str) || str.Length<8 || str.Length>25)
                return false;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            
            return false;
        }

    }
}
