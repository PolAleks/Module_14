using System.Security.Cryptography.X509Certificates;

namespace Task_14_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три",
                              "четыре пять шесть",
                              "семь восемь девять" };

            var result = from txt in text
                         from word in txt.Split(' ')
                         select word;


            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }
    }
}