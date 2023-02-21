namespace Task_14_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var select = from word in words
                         orderby word.Length
                         select new
                         {
                             Word = word,
                             Lenth = word.Length
                         };

            foreach (var word in select)
                Console.WriteLine(word.Word + " - " + word.Lenth);

            Console.WriteLine(new string('-', 20));

            select = words.Select(word => new
                                  {
                                      Word = word,
                                      Lenth = word.Length
                                  })
                           .OrderBy(word => word.Lenth);

            foreach (var word in select)
                Console.WriteLine(word.Word + " - " + word.Lenth);
        }
    }
}