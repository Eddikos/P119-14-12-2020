using System;

namespace _12132020
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = PrintWorkDays();

            Country aze = new Country();
            aze.Name = "Azerbaijan";
            aze.Population = 0;
            aze.UniqueId = 1;

            City baku = new City();
            baku.Name = "Baku";
            baku.Population = 4000000;
            baku.UniqueId = 2;

            //aze.ListCities();

            aze.AddCity(baku);

            aze.ListCities();

            aze.DeleteCity(2);

            aze.ListCities();

            int[] a = new int[];
            City[] elovset = new City[];
        }

        public static int PrintWorkDays()
        {
            DateTime startDate = new DateTime(2020, 12, 01);
            DateTime endDate = new DateTime(2020, 12, 31);

            DateTime[] holidays = { new DateTime(2020, 12, 19), new DateTime(2020, 12, 31) };
            int numberOfCalendarDays = (endDate - startDate).Days + 1;
            int daysOff = 0;

            while (startDate <= endDate)
            {
                var currentDate = startDate;

                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                    daysOff++;

                if (Array.IndexOf(holidays, currentDate) != -1)
                    daysOff++;

                startDate = startDate.AddDays(1);
            }

            return numberOfCalendarDays - daysOff;
        }
    }

    class City
    {
        public int UniqueId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public override string ToString()
        {
            return this.Name + " - " + this.UniqueId;
        }
    }

    class Country
    {
        public int UniqueId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public City[] Cities { get; set; }

        public Country()
        {
            this.Cities = new City[] { };
        }

        public override string ToString()
        {
            return this.Name;
        }

        public void ListCities()
        {
            foreach (var city in this.Cities)
            {
                Console.WriteLine(city.ToString());
            }
        }

        public void AddCity(City newCity)
        {
            City[] citiesArray = this.Cities;
            Array.Resize(ref citiesArray, citiesArray.Length + 1);
            citiesArray[citiesArray.Length - 1] = newCity;
            this.Cities = citiesArray;
        }

        public void DeleteCity(int cityId)
        {
            var citiesArray = this.Cities;
            var lessCities = Array.FindAll(citiesArray, city => city.UniqueId != cityId);
            this.Cities = lessCities;
        }
    }
}
