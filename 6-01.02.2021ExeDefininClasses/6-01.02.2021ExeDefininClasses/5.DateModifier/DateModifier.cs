using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class DateModifier
    {
        public static int GetDiffBetweenDatesInDays(string dateOneString,string dateTwoString)
        {

            DateTime dateOne = DateTime.Parse(dateOneString);
            DateTime dateTwo = DateTime.Parse(dateTwoString);
            TimeSpan time = dateOne - dateTwo;
            return Math.Abs(time.Days);

        }
    }
}
