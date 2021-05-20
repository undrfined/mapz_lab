namespace Lab4.Stats
{
    public abstract class StatsDecorator : Stats
    {
        protected Stats Stats;

        protected StatsDecorator(Stats stats, string name) : base(name)
        {
            Stats = stats;
        }
    }
}