using System.Text;

namespace UtilizationFactory.View
{
    public class Display
    {
        Dictionary<string, int> wasteTonage;
        public Display()
        {
            wasteTonage = new Dictionary<string, int>();
        }
        public Dictionary<string, int> Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("WELCOME TO UTILIZATION FACTORY");
            sb.AppendLine("Please provide your load weight");
            sb.AppendLine("-------------------------------");
            Console.WriteLine(sb);
            Console.Write("Metal (tons): ");
            var metalWeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Paper (tons): ");
            var paperWeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Other waste (tons): ");
            var otherWasteWeight = Convert.ToInt32(Console.ReadLine());
            
            wasteTonage["METAL"] = metalWeight;
            wasteTonage["PAPER"] = paperWeight;
            wasteTonage["OTHER"] = otherWasteWeight;


            return wasteTonage;
        }

        public void DisplayResult(int result)
        {
            Console.WriteLine("------R-E-S-U-L-T-------");
            Console.WriteLine($"THE UTILIZATION PROCESS WILL TAKE {result} DAYS THANK YOU!");
        }
    }
}
