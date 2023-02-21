namespace Task_14_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
               new[] {2, 3, 7, 1},
               new[] {45, 17, 88, 0},
               new[] {23, 32, 44, -6},
            };

            var result = from nums in numsList
                         from num in nums
                         orderby num
                         select num;

            foreach (int num in result)
                Console.WriteLine(num);

            Console.WriteLine(new string('-', 20));

            result = numsList.SelectMany(s => s).OrderBy(s => s);

            foreach (int num in result) Console.WriteLine(num);
        }
    }
}