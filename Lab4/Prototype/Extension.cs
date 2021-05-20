namespace Lab4.Prototype
{
    public class Extension : IProduct
    {
        public string GetName()
        {
            return "Extension";
        }

        public IProduct Clone()
        {
            return MemberwiseClone() as IProduct;
        }
    }
}