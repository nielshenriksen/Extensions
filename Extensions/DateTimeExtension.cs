using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class DateTimeExtension
    {
        static public int Age(this System.DateTime dateOfBirth)
        {
            if (System.DateTime.Today.Month < dateOfBirth.Month ||
            System.DateTime.Today.Month == dateOfBirth.Month &&
             System.DateTime.Today.Day < dateOfBirth.Day)
            {
                return System.DateTime.Today.Year - dateOfBirth.Year - 1;
            }
            else
                return System.DateTime.Today.Year - dateOfBirth.Year;
        }

        static public bool IsThisDate(this System.DateTime now, System.DateTime datetime)
        {
            return now.Year == datetime.Year && now.Month == datetime.Month && now.Day == datetime.Day;
        }

        static public bool IsBetween(this System.DateTime now, System.DateTime start, System.DateTime end)
        {
            return start <= now && now <= end;
        }

        static public bool IsDateBeforeOrEqual(this System.DateTime now, System.DateTime datetime)
        {
            var d1 = new System.DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            var d2 = new System.DateTime(datetime.Year, datetime.Month, datetime.Day, 0, 0, 0);
            return d1 <= d2;
        }

        static public bool IsDateAfterOrEqual(this System.DateTime now, System.DateTime datetime)
        {
            var d1 = new System.DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            var d2 = new System.DateTime(datetime.Year, datetime.Month, datetime.Day, 0, 0, 0);
            return d1 >= d2;
        }

        static public bool IsDateBefore(this System.DateTime now, System.DateTime datetime)
        {
            var d1 = new System.DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            var d2 = new System.DateTime(datetime.Year, datetime.Month, datetime.Day, 0, 0, 0);
            return d1 < d2;
        }

        static public bool IsDateAfter(this System.DateTime now, System.DateTime datetime)
        {
            var d1 = new System.DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            var d2 = new System.DateTime(datetime.Year, datetime.Month, datetime.Day, 0, 0, 0);
            return d1 > d2;
        }

        static public bool IsBefore(this System.DateTime now, System.DateTime datetime)
        {
            return now <= datetime;
        }

        static public bool IsAfter(this System.DateTime now, System.DateTime datetime)
        {
            return now >= datetime;
        }
    }
}
