using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Method
{
    public static class Helper
    {
        // GetFullName Method -- return string
        public static string GetFullName()
        {
            return "Erfan Edalati";
        }


        // GetWelcomeMessage Method -- return string
        public static string GetWelcomeMessage()
        {
            return "Welcome " + "Erfan Edalati";
        }


        //GetProfile Method with Input -- return string
        public static string GetProfile(string name, string lastName)
        {
            return name + " " + lastName;
        }


        //GetNumber Method -- return int
        public static int GetNumber()
        {
            return 10;
        }


        //Sum Method with Input -- return int
        public static int Sum(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        //GetIsThere Method -- return bool
        public static bool GetIsThere()
        {
            return true;
        }
    }
}
