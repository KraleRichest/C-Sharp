using System;

namespace SEDC.Oop.Class04.Methods.Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime();
            //Console.WriteLine(date);

            //DateTime customeData = new DateTime(1992, 10, 15);
            //Console.WriteLine(customeData);

            //string date1 = "12.15.2012";
            //string date2 = "12/15/2012";
            //string date3 = "12/15/12";
            //string date4 = "dec.15.12";
            //string date5 = "12-15-2012";

            //DateTime convertedDate1 = DateTime.Parse(date1);
            //DateTime convertedDate2 = DateTime.Parse(date2);
            //DateTime convertedDate3 = DateTime.Parse(date3);
            //DateTime convertedDate4 = DateTime.Parse(date4);
            //DateTime convertedDate5 = DateTime.Parse(date5);
            //Console.WriteLine(convertedDate1);
            //Console.WriteLine(convertedDate2);
            //Console.WriteLine(convertedDate3);
            //Console.WriteLine(convertedDate4);
            //Console.WriteLine(convertedDate5);

            //DateTime currentDay = DateTime.Today;
            //Console.WriteLine(currentDay);

            //DateTime currentDateAndTime = DateTime.Now;
            //Console.WriteLine(currentDateAndTime);

            //DateTime currentDate = DateTime.Today.Date;
            //Console.WriteLine(currentDate);

            //DateTime addedDays = currentDateAndTime.AddDays(5);
            //DateTime removeDays = currentDateAndTime.AddDays(-10);
            //DateTime addMonth = currentDateAndTime.AddMonths(2);
            //DateTime addingYears = currentDateAndTime.AddYears(1);

            //int year = currentDateAndTime.Year;
            //int day = currentDateAndTime.Day;

            //int dayInTheYear = currentDateAndTime.DayOfYear;
            //Console.WriteLine(dayInTheYear);


            //string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
            //string dateFormat2 = currentDateAndTime.ToString("dddd,dd MMMM yyyy");
            //string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:t}", currentDay);
            

            //Console.WriteLine(dateFormat1);
            //Console.WriteLine(dateFormat2);
            //Console.WriteLine(dateFormat3);


            DateTime currentDay = DateTime.Now;
            Console.WriteLine(currentDay);

            DateTime threeDaysFromNow = currentDay.AddDays(3);
            Console.WriteLine(threeDaysFromNow);
            DateTime oneMonthFromNow = currentDay.AddMonths(1);
            Console.WriteLine(oneMonthFromNow);
            DateTime oneMOnthAndThreeDays = currentDay.AddMonths(1).AddDays(3);
            Console.WriteLine(oneMOnthAndThreeDays);
            DateTime oneYearAndTwoMonthsAgo = currentDay.AddYears(-1).AddMonths(-2);
            Console.WriteLine(oneYearAndTwoMonthsAgo);
            int currentMonthNow = currentDay.Month;
            Console.WriteLine(currentMonthNow);
            int currentYearNow = currentDay.Year;
            Console.WriteLine(currentYearNow);






            Console.ReadLine();
        }
    }
}
