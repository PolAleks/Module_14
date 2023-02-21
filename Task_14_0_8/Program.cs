namespace Task_14_0_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
               1,
               "Сергей ",
               "Андрей ",
               300,
            };

            var selectString = from obj in objects
                               where obj is string
                               orderby obj
                               select obj;

            foreach (var obj in selectString)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(new string('-', 25));

            foreach(var obj in objects.Where(o => o is string).OrderBy(o => o))
                Console.WriteLine(obj);
        }
    }
}