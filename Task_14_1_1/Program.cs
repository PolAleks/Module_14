using System.Text;

namespace Task_14_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var selectCity = from city in russianCities
                             where city.Name.Length <= 10
                             orderby city.Name.Length
                             select city;

            foreach (var city in selectCity)
            {
                Console.WriteLine(city.Name);
            }

            Console.WriteLine(new string('-', 25));

            selectCity = russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length);

            foreach (var city in selectCity)
            {
                Console.WriteLine(city.Name);
            }

        }
    }
}