namespace StaticExampleInUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Order o1 = new Order();
            Console.WriteLine(o1.ToString());
            Thread.Sleep(100);
            Order o2 = new Order();
            Console.WriteLine(o2.ToString());
            Thread.Sleep(100);
            Order o3 = new Order();
            Console.WriteLine(o3.ToString());
            Console.ReadKey();
        }
    }
}
