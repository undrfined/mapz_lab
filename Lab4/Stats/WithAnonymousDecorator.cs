namespace Lab4.Stats
{
    public class WithAnonymousDecorator : StatsDecorator
    {
        public WithAnonymousDecorator(Stats stats) : base(stats, stats.Name + " (including anonymous users)")
        {
        }

        public override int GetViewCount()
        {
            return Stats.GetViewCount() + 60;
        }

        public override string ToJson()
        {
            return $"{{\"count\": {GetViewCount()}, \"anonymous\": 60}}";
        }
    }
}