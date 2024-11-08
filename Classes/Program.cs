namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car van = new Car();
            van.Make = "Ford";
            van.Model = "HighRoof Van";
            van.Year = 2025;
            
            Console.WriteLine(van.Make);
            Console.WriteLine(van.Model);
            Console.WriteLine(van.Year);
        }
    }
}
