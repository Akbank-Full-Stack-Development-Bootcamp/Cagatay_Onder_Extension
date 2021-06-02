using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions.Extensions
{
    public static class HowManyDays
    {
        public static int CalculateDays(this DateTime bornDate)
{
            TimeSpan difference = DateTime.Now - bornDate;
            return difference.Days;
        }
    }
}
