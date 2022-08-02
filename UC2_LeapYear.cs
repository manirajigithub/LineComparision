using System;
using System.Collections.Generic;
using System.Text;

namespace LeapYear

{
        public static class UC2_LeapYear
        {
        public static void CheckUC2_LeapYear()
        {
            Console.WriteLine("Enter Year is four digit Number");
            int Year = Convert.ToInt32(Console.ReadLine());

            if ((Year % 4 == 0) || (Year % 100 != 0) && (Year % 4 == 0))
            {

                Console.WriteLine("  Leap year  " );
            }

            else
            {
                Console.WriteLine("  Not leap year  ");
            }
        }
    }
}