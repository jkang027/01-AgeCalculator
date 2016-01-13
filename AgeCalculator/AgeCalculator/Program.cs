using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Prompt user to enter birthdate.
            Console.WriteLine("When is your birthday?");
            var userInput = Console.ReadLine();

            //Parse userInput to DateTime. Declare current DateTime.
            DateTime userBirthday = DateTime.Parse(userInput);
            DateTime current = DateTime.Now;

            //Calculate difference between userInput and current DateTimes.
            var ageDiff = current.Subtract(userBirthday);
            
            //Create variables based on TimeSpan.
            var ageYears = ageDiff.TotalDays / 365.2436875;
            var ageYearsRem = ageDiff.TotalDays % 365.2436875;
            var ageYearsTotal = Math.Floor(ageDiff.TotalDays / 365.243687);
            var ageMonths = ageDiff.TotalDays / 30.436875;
            var ageMonthsRem = ageYearsRem % 30.436875;
            var ageMonthsTotal = Math.Floor(ageYearsRem / 30.436875);
            var ageWeeks = ageDiff.TotalDays / 7;
            var ageWeeksRem = ageMonthsRem % 7;
            var ageWeeksTotal = Math.Floor(ageMonthsRem / 7);
            var ageDays = ageDiff.TotalDays;
            var ageDaysRem = ageWeeksRem % 1;
            var ageDaysTotal = Math.Floor(ageWeeksRem / 1);
            var ageHours = ageDiff.TotalHours;
            var ageHoursRem = ageDaysRem % 0.041667;
            var ageHoursTotal = Math.Floor(ageDaysRem / 0.041667);
            var ageMinutes = ageDiff.TotalMinutes;
            var ageMinutesRem = ageHoursRem % 0.000694;
            var ageMinutesTotal = Math.Floor(ageHoursRem / 0.000694);
            var ageSeconds = ageDiff.TotalSeconds;
            var ageSecondsRem = ageMinutesRem % 0.00001157;
            var ageSecondsTotal = Math.Floor(ageMinutesRem / 0.00001157);
            var ageMilliseconds = ageDiff.TotalMilliseconds;
            var ageMillisecondsRem = ageSecondsRem % 0.00000001157;
            var ageMillisecondsTotal = Math.Floor(ageSecondsRem / 0.00000001157);

            //Print the age.
            Console.WriteLine("You are " + ageYearsTotal + " years, " + ageMonthsTotal + " months, " + ageWeeksTotal + " weeks, " + ageDaysTotal + " days, " + ageHoursTotal + " hours, " + ageMinutesTotal + " minutes, " + ageSecondsTotal + "seconds, and " + ageMillisecondsTotal + "milliseconds old.");

            //Hit 'enter' to end.s
            Console.WriteLine("Hit 'enter' to end.");
            Console.ReadLine();
        }
    }
}