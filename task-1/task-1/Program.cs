namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumSum();
        }
        public static void NumSum()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Sum of entered numbers : {sum}.");
        }
    }
}