using System.Runtime.InteropServices;

namespace Task_14_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
            };

            // Список курсов
            var courses = new List<Course>
            {
               new Course {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
               new Course {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };

            var selectStudents = from student in students
                                 where student.Age < 29 && student.Languages.Contains("английский")
                                 let birthYear = DateTime.Now.Year - student.Age
                                 from course in courses
                                 where course.Name.Contains("C#")
                                 select new
                                 {
                                     Name = student.Name,
                                     Age = birthYear,
                                     Course = course.Name
                                 };       

            foreach (var student in selectStudents)
            {
                Console.WriteLine(student.Name + " " + student.Age + 
                                  " года рождения. записан на курс: " + 
                                  student.Course);
            }
        }
    }
}