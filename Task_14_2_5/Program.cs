namespace Task_14_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            while (true)
            {
                char keyChar = Console.ReadKey().KeyChar;
                Console.Clear();

                if(!char.IsDigit(keyChar))
                {
                    Console.WriteLine("Вы ввели недопустимое значение");
                }
                else if (keyChar == '1' || keyChar == '2' || keyChar == '3')
                {
                    int.TryParse(keyChar.ToString(), out int temp);
                    var selectContact = contacts.Skip((temp - 1) * 2).Take(2);

                    foreach (var contact in selectContact)
                        Console.WriteLine(contact.Name);
                }
                else
                {
                    Console.WriteLine("Такой страницы не существует!");
                }
            }
        }
    }
}