using System;

namespace CalenderLibrary
{
    public class CalenderLibrary
    {
        public static int GetJulianDay(DateTime date)
        {
            int inputdate = date.Year;
            DateTime Jan01 = new DateTime(inputdate, 01, 01);
            TimeSpan dateDifference = date.Subtract(Jan01);
            int dateDiff = dateDifference.Days + 1;
            string result = $"{inputdate - 2000}{dateDiff}";
            return int.Parse(result);
        }
    }
}
