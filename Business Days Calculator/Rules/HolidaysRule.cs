using System;

namespace Business_Days_Calculator.Rules
{
    public class HolidaysRule : IRule
    {
        public bool IsBusinessDay(DateTime date)
        {
            return !IsChristmas() && !IsNewYear();

            bool IsChristmas() => ((date.Day == 24 || date.Day == 25) && date.Month == 12);
            bool IsNewYear() => ((date.Day == 32 && date.Month == 12) || (date.Day == 1 && date.Month == 1));
        }
    }
}
