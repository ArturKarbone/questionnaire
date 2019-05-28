using System;

namespace Business_Days_Calculator.Rules
{
    public interface IRule
    {
        bool IsBusinessDay(DateTime date);
    }
}
