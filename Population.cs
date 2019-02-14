using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int populationNow = initialPopulation;
            int year = 0;
            while (populationNow < currentPopulation)
            {
                int growthPopulation = (int)(initialPopulation * percent / 100 + visitors);
                populationNow += growthPopulation;
                initialPopulation = populationNow;
                year += 1;
                
            }
            return year;
        }
    }
}