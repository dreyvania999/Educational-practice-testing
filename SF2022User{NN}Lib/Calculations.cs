using System;
using System.Collections.Generic;

namespace SF2022User_NN_Lib
{
    public class Calculations
    {

        public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            List<TimeSpan> WorkTime = new List<TimeSpan>();
            int i = 0;
            while (beginWorkingTime< endWorkingTime)
            {
                if (startTimes.Length!=i&& durations.Length != i)
                {
                    if (beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0)) > startTimes[i])
                    {
                        beginWorkingTime = startTimes[i].Add(new TimeSpan(0, durations[i], 0));
                        i++;
                        continue;
                    }
                }
                WorkTime.Add(beginWorkingTime);
                beginWorkingTime = beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0));
            }
            List<string> strings = new List<string>();
            foreach (var item in WorkTime)
            {
                strings.Add(item.ToString(@"hh\:mm") + "-" + item.Add(new TimeSpan(0, consultationTime, 0)).ToString(@"hh\:mm"));
            }
            
            return strings.ToArray();
        }
    }
}
