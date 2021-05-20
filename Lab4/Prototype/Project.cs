namespace Lab4.Prototype
{
    public class Project : IProduct
    {
        private readonly string _name;

        public Project(string name)
        {
            _name = name;
        }
        
        public string GetName()
        {
            return "Project " + _name;
        }

        public IProduct Clone()
        {
            return MemberwiseClone() as IProduct;
        }
    }
}