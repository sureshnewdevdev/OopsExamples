namespace SaleSampleProj
{
    using ProductProj;
    internal class Program
    {
        public Program()
        {
            GF = 89.4F;
        }


        public double GF { get;  }
        static void Main(string[] args)
        {
            
            ProductProj.Product product = new ProductProj.Product();
            Console.WriteLine("Hello, World!");

        }
    }
}
