namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            LineCompare obj_One = new LineCompare(2, 3, 4, 5);
            double length_One = obj_One.Calculate();
            LineCompare obj_Two = new LineCompare(2, 8, 4, 5);
            double length_Two = obj_Two.Calculate();
            if (length_One.Equals(length_Two))
            {
                Console.WriteLine("Length of both lines are equal");
            }
            else
            {
                Console.WriteLine("Length of both lines are not equal");
            }

            if (length_One.CompareTo(length_Two) == 0)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (length_One.CompareTo(length_Two) > 0)
            {
                Console.WriteLine("Line one is greater than line two");
            }
            else
            {
                Console.WriteLine("Line two is greater than line one");
            }
            Console.ReadKey();
        }
    }
}