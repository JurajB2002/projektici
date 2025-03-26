namespace WheatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi za koliko dana želiš simulirati weather conditions");
            int Days = int.Parse(Console.ReadLine());
            Random random = new Random();

            string[] WeatherConditions = { "Sunny", "Snowy", "Windy", "Rainy" };
            double[] Temperature = new double[Days];
            string[] ActualConditions = new string[Days];
            for (int i = 0; i < Days; i++)
            {
                Temperature[i] = random.Next(-10, 40);
                ActualConditions[i] = WeatherConditions[random.Next(WeatherConditions.Length)];
                Console.WriteLine(Temperature[i]);
                Console.WriteLine(ActualConditions[i]);
            }
            double AverageTemp = Calculateaverage(Temperature);
            double MaxTemp = Maxvalue(Temperature);
            double MinTemp = Minvalue(Temperature);
            string MostCom = MostComon(ActualConditions);
            Console.WriteLine($"Average temperature je {AverageTemp}");
            Console.WriteLine($"Max value in temperature is {MaxTemp}");
            Console.WriteLine($"Min value in temperature is {MinTemp}");
            Console.WriteLine($"Most common condition is {MostCom}");
            Console.ReadLine();



        }
        static double Calculateaverage(double[] temperature)
        {
            double AddTemperature = 0;
            double AverageTemperature = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                AddTemperature = AddTemperature + temperature[i];
            }
            AverageTemperature = AddTemperature / temperature.Length;
            return AverageTemperature;

        }
        static double Maxvalue(double[] temperature)
        {

            double max = temperature[0];
            for (int i = 0; i < temperature.Length; i++)
            {
                if (max > temperature[i])
                {
                    max = max;
                }
                else
                {
                    max = temperature[i];
                }
            }
            return max;
        }
        static double Minvalue(double[] temperature)
        {

            double max = temperature[0];
            for (int i = 0; i < temperature.Length; i++)
            {
                if (max < temperature[i])
                {
                    max = max;
                }
                else
                {
                    max = temperature[i];
                }
            }
            return max;
        }
        static string MostComon(string[] ActualConditions)
        {
            int count = 0;

            string MostCommonCondition = ActualConditions[0];
            string SecondCommonCondition = ActualConditions[0];
            for (int i = 0; i < ActualConditions.Length; i++)
            {
                int tempcount = 0;

                for (int j = 0; j < ActualConditions.Length; j++)
                {
                    if (ActualConditions[i] == ActualConditions[j])
                    {
                        tempcount++;

                    }
                    if (tempcount > count)

                    {
                        count = tempcount;
                        MostCommonCondition = ActualConditions[i];
                    }
                    if (tempcount == count)
                    {
                        SecondCommonCondition = ActualConditions[i];
                    }

                }

            }

            return MostCommonCondition;
        }

    }
}