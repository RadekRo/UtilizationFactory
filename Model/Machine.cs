namespace UtilizationFactory.Model
{
    public abstract class Machine
    {
        public int dailyThroughput {  get; set; }

        public int calculateDays(int loadWeight)
        {
            return (int)Math.Ceiling((double)loadWeight / dailyThroughput);
        }
    }
}
