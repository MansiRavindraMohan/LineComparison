namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            LineCompare obj = new LineCompare(2, 3, 4, 5);
            obj.Calculate();
            Console.ReadKey();
        }
    }
}