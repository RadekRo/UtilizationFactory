using UtilizationFactory.Controller;
using UtilizationFactory.Model;
using UtilizationFactory.View;

namespace UtilizationFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            UtilizationProcess process = new UtilizationProcess();
            var tonageDict = display.Menu();
            process.CalculateUtilizationProcessDaysLength(tonageDict);
        }
    }
}