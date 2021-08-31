using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validations1
{
    public static class StringExtensions
    {

        /*
         \d = digit
        \D = Alafabeta
         . = Any char
        
        [^abc]
        [A-Z] 
        [a-z]

        /* ******************************
        "a+" = one or more times
        "a*" = zero or any times
        "a{5}" = 5 times
        "a{5,25}" = repits between 5 to 25 times


        "^D.*" = string that starts with D

        D290421ex
        
        "^[DFJ]/d{6}/D{2} "

         */
        static string myExpression = @"\d\d"; //01

        public static bool IsValidName(this string name)
        {
            //if (name.Length < 2) return false;
            var regex = new Regex(@"\D{2,50} \D{0,50}"); //
            return regex.IsMatch(name);
            foreach (var characater in name)
            {
                if (characater < 'A' || characater > 'z' || characater == '\'') return false;
            }

            return true;
        }

        public static bool IsCourseName(this string str)
        {
            var expression = @"^[DFJ]\d{6}\D{2}";
            return new Regex(expression).IsMatch("D290421ex"); //

        }

        public static void SplitSample()
        {
            var myArray = new Regex(@",\s*").Split("Moshe,David,Od Mishhu,...");
        }

        public static bool IsIlIdentity(this string str)
        {
            
            
            //if (name.Length != 9) return false;
            //foreach (var characater in name.PadLeft(9, '0'))
            //{
            //    if (characater < '0' || characater > '9') return false;
            //}

            //instead of the above lines, use RegEx
            return new Regex(@"^\d{9}$").IsMatch(str);
        }


    }
}
