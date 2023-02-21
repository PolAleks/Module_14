namespace Task_14_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            var selectCompanies = companies.Where(c => c.Value.Contains("Mobile")).Select(c => c.Key);

            foreach (var c in selectCompanies)
            {
                Console.WriteLine(c);
            }

        }
    }
}