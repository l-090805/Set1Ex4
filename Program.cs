namespace Set1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int an;
            Console.Write("Introduceti un an: ");
            an = int.Parse(Console.ReadLine());

            if (an % 4 == 0 && an % 100 != 0 || an % 400 == 0)
            {
                Console.WriteLine($"{an} este un an bisect");
            }
            else
            {
                Console.WriteLine($"{an} nu este un an bisect");
            }

        }
    }
}
