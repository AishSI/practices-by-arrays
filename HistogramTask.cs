using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {                
            var dayMonth = new string[31];
            for (var x = 0; x < dayMonth.Length; x++)
                dayMonth[x] = (x + 1).ToString();
            var samplingName = new double[31];
            foreach (var nameFind in names)
            {
                if (nameFind.Name == name && nameFind.BirthDate.Day != 1) 
                samplingName[nameFind.BirthDate.Day-1]++;
            }

            //return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), new string[0], new double[0]);
            return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), dayMonth, samplingName);
        }
    }
}