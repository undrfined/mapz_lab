namespace Lab4.Stats
{
    public class ExtensionStats : Stats
    {
        public override int GetViewCount()
        {
            return 100;
        }

        public override string ToJson()
        {
            return $"{{\"count\": {GetViewCount()}}}";
        }

        public ExtensionStats() : base("Extension Stats")
        {
        }
    }
}