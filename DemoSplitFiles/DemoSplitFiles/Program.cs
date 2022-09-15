namespace DemoSplitFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hm = new Human("Carl", "Johnson", false);
            hm.Print();
            Citizen ct = new Citizen("Valeriy", "Zhmyshenko", false, "GaDzA228", "Samara");
            Console.WriteLine("------------------------");
            ct.Print();
            ForeignCitizen fc = new ForeignCitizen("Orlov", "Vladislav", false, "0230902ADK", "London", "TP8ple5f", Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2085"));
            Console.WriteLine("------------------");
            fc.Print();
        }
    }
}