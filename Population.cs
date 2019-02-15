using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation<= 0 || currentPopulation <= 0)
            {
                throw new ArgumentException();
            }
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