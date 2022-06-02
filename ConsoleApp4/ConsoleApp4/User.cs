using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class User
    {
         public User(string Username)
        {
            UserName = Username;
        }

        private string _username;
        private string _password;

     
       
        public string UserName  
        {
            get => _username;
            set
            {
               
                if (!String.IsNullOrEmpty(value)&& (value.Length>5) && value.Length<26 )
                {
                
                    {
                        _username = value;
                    }

                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (!String.IsNullOrEmpty(value) && (value.Length > 7) && (value.Length < 26) )
                {
                    int countDigit = 0;
                    int countUpper = 0;
                    int countLower = 0;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsDigit(value[i]))
                            countDigit++;
                        else if (Char.IsUpper(value[i]))
                            countUpper++;
                        else if (Char.IsLower(value[i]))
                            countLower++;

                    }
                    if (countDigit != 0 && countUpper != 0 && countLower != 0)
                    {
                        _password = value;  
                    }
                }
            }
        }
    }
}
