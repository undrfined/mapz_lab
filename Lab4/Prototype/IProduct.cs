namespace Lab4.Prototype
{
    public interface IProduct
    {
        public string GetName();
        public IProduct Clone();
    }
}