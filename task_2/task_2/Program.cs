namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseNum();
        }
        public static void ReverseNum()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (j >= i)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}