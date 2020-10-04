using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Services
{
    public class DateTimeFormater : IDateTimeFormater
    {
        public string GetFormattedDate(DateTime dateTime)
        {
            string day;
            string month;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    day = "Fri";
                    break;
                case DayOfWeek.Monday:
                    day = "Mon";
                    break;
                case DayOfWeek.Saturday:
                    day = "Sat";
                    break;
                case DayOfWeek.Sunday:
                    day = "Sun";
                    break;
                case DayOfWeek.Thursday:
                    day = "Thu";
                    break;
                case DayOfWeek.Tuesday:
                    day = "Tue";
                    break;
                case DayOfWeek.Wednesday:
                    day = "Wed";
                    break;
                default:
                    day = "Unknown";
                    break;
            }

            switch (dateTime.Month)
            {
                case 1:
                    month = "Jan";
                    break;
                case 2:
                    month = "Feb";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Apr";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Jun";
                    break;
                case 7:
                    month = "Jul";
                    break;
                case 8:
                    month = "Aug";
                    break;
                case 9:
                    month = "Sep";
                    break;
                case 10:
                    month = "Oct";
                    break;
                case 11:
                    month = "Nov";
                    break;
                case 12:
                    month = "Dec";
                    break;
                default:
                    month = "Unknown";
                    break;
            }

            return day + ", " + dateTime.Day + " " + month + " " + dateTime.Year;
        }
        public string GetFormattedTime(DateTime dateTime)
        {
            return dateTime.ToShortTimeString();
        }
    }

}
