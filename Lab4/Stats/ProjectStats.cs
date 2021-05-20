namespace Lab4.Stats
{
    public class ProjectStats : Stats
    {
        public override int GetViewCount()
        {
            return 20;
        }

        public override string ToJson()
        {
            return $"{{\"count\": {GetViewCount()}}}";
        }

        public ProjectStats() : base("Project Stats")
        {
        }
    }
}