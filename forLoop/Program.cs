namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (var i = 0; i <= 100; i++)
            { 
                Console.WriteLine(i);
                if (i % 5 == 0 || i % 7 == 0)
                {
                    sum = sum + i;

                }
            }
                Console.WriteLine(sum);
        }
    }
}
