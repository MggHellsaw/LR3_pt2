namespace LR3_2.Services
{
    using System;

    public interface ITimeOfDayService
    {
        string GetTimeOfDay();
    }

    public class TimeOfDayService : ITimeOfDayService
    {
        public string GetTimeOfDay()
        {
            var now = DateTime.Now;
            var hour = now.Hour;

            if (hour >= 6 && hour < 12)
            {
                return "зараз ранок";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "зараз день";
            }
            else if (hour >= 18 && hour < 24)
            {
                return "зараз вечір";
            }
            else
            {
                return "зараз ніч";
            }
        }
    }
}
