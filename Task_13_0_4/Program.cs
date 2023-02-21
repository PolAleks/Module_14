namespace Task_14_0_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            #region Select and sort array

            List<string> list = new List<string>();

            foreach (string person in people)
            {
                if (person.ToUpper().StartsWith('А'))
                    list.Add(person);
            }

            list.Sort();

            foreach (string person in list)
            {
                Console.WriteLine(person);
            }

            #endregion

            Console.WriteLine(new string('-',25));

            #region Select and Sort with LINQ

            var selectPeople = from p in people
                               where p.StartsWith('А')
                               orderby p
                               select p;

            foreach (var person in selectPeople) {
                Console.WriteLine(person);
            }
            #endregion

            Console.WriteLine(new string('-', 25));

            #region Select and Sord with Extension Methods

            var selectPeopleWithExtensionMethod = people.Where(p => p.StartsWith('А')).OrderBy(p => p);

            foreach (var person in selectPeopleWithExtensionMethod)
            {
                Console.WriteLine(person);
            }
            #endregion
        }
    }
}