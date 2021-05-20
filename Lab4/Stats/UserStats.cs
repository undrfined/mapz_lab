namespace Lab4.Stats
{
    public class UserStats : Stats
    {
        public override int GetViewCount()
        {
            return 100;
        }

        public override string ToJson()
        {
            return $"{{\"count\": {GetViewCount()}}}";
        }

        public UserStats() : base("User stats")
        {
        }
    }
}