using System;

namespace Business_Days_Calculator.Rules
{
    public class WeekendRule : IRule
    {
        public bool IsBusinessDay(DateTime date)
        {
            return !(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }
    }
}
