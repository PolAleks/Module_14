namespace Task_14_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
                new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
                new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } },
                new Student { Name = "Василий", Age = 24, Languages = new List<string> { "испанский", "немецкий" } }
            };

            var selectStudent = from student in students
                                where student.Age < 27
                                let yearOfBirth = DateTime.Now.Year - student.Age
                                select new Application()
                                {
                                    Name = student.Name,
                                    DayOfBirth = yearOfBirth
                                };

            foreach (var student in selectStudent)
            {
                Console.WriteLine($"Студент {student.Name} {student.DayOfBirth} года рождения");
            }
        }
    }
}