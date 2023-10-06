using UtilizationFactory.Model;

namespace UtilizationFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crusher crusher = new();
            Console.WriteLine(crusher.calculateDays(20));

        }
    }
}