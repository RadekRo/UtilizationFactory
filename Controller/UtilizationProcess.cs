using UtilizationFactory.Model;
using UtilizationFactory.View;

namespace UtilizationFactory.Controller
{
    public class UtilizationProcess
    {
        Crusher crusher;
        Shredder shredder;
        Incinerator incinerator;
        Display display = new Display();

        public UtilizationProcess()
        {
            crusher = new Crusher();
            shredder = new Shredder();
            incinerator = new Incinerator();
        }

        public void CalculateUtilizationProcessDaysLength(Dictionary<string, int> wasteTonage)
        {
            int crushDays = crusher.calculateDays(wasteTonage["METAL"]);
            int shredDays = shredder.calculateDays(wasteTonage["PAPER"]);
            int inciDays = incinerator.calculateDays(wasteTonage["OTHER"]);

            int longestPeriod = Math.Max(crushDays, Math.Max(shredDays, inciDays));

            display.DisplayResult(longestPeriod);

        }
    }
}
