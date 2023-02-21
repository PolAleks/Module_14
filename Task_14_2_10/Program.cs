namespace Task_14_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while(true)
            {
                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int page))
                {
                    Console.Clear();

                    if (page > 0 && page < 4)
                    {
                        var selectPageContact = phoneBook.Skip((page - 1) * 2).Take(2);

                        foreach (var contact in selectPageContact)
                        {
                            Console.WriteLine(contact.Name + " " + contact.LastName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такой страницы не существует!");
                    }
                }
                else
                {
                    Console.Clear();  
                    Console.WriteLine("Вы ввели некорректный символ");
                }
            }
        }
    }
}