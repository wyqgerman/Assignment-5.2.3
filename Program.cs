namespace Assignment_5._2._3
{
    internal class Program
    {
        public static void PrintNumbersReverse(int n)
        {
            if (n <= 0)
            {
                return;
            }

            Console.Write(n + " ");

            PrintNumbersReverse(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("How many numbers to print: ");
            int n = int.Parse(Console.ReadLine());

            PrintNumbersReverse(n);

            Console.WriteLine();
        }
    }
}
