using System;

namespace Names
{
    internal static class HeatmapTask
    {
        enum Month
        {
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            //var proba = Month;
            var dayMonth = new string[30];
            var monthYear = new string[12];
            var peopleBornOfTheDay = new double[30, 12];
            for (var x = 0; x < dayMonth.Length; x++)
                dayMonth[x] = (x + 2).ToString();
            for (var y = 0; y < monthYear.Length; y++)
                monthYear[y] = Enum.Format(typeof(Month), y, "F");
            foreach (var birthday in names)
            {
                // это решение практики "Тепловая карта"
                //if (birthday.BirthDate.Day > 1)
                //    peopleBornOfTheDay[birthday.BirthDate.Day - 2, birthday.BirthDate.Month - 1]++;

                //Просто поискал Иванов с ДР 03.11
                if (birthday.BirthDate.Day == 3)
                    if (birthday.BirthDate.Month == 11)
                        if (birthday.Name == "иван")
                            peopleBornOfTheDay[birthday.BirthDate.Day - 2, birthday.BirthDate.Month - 1]++;
            }
            return new HeatmapData("Пример карты интенсивностей", peopleBornOfTheDay, dayMonth, monthYear);
        }
    }
}