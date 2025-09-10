namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            Console.WriteLine("Gæt et tal er ikke implementeret endnu.");
            Random ellasfingrer = new Random();
            int ellasfingrer1 = ellasfingrer.Next(1, 10);
            Console.WriteLine($"pssst, Ella er ikke god til det med fingrer: {ellasfingrer}");
            Console.ReadKey();
        }
    }
}
