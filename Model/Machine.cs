namespace UtilizationFactory.Model
{
    public abstract class Machine
    {
        public int dailyThroughput;

        public int calculateDays(int loadWeight)
        {
            return (int)Math.Ceiling((double)loadWeight / dailyThroughput);
        }
    }
}
