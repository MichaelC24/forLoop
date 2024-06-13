namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //for (var i = 0; i <= 100; i++)
            //{ 
            //    Console.WriteLine(i);
            //    if (i % 5 == 0 || i % 7 == 0)
            //    {
            //        sum = sum + i;

            //    }
            //}
            //    Console.WriteLine(sum);
            
            int firstnmbr = 0;
            int secondnmbr = 1;
            Console.Write($"{firstnmbr}, {secondnmbr} ");
            int thirdnmbr = 0;

            //for (int i = 0; i <= 10; i++)
            while (thirdnmbr <= 25) 
            {
                thirdnmbr = firstnmbr + secondnmbr;
                Console.Write($"{thirdnmbr}, ");
                firstnmbr = secondnmbr;
                secondnmbr = thirdnmbr;
                
                //if (firstnmbr > 25) { break;} 
                
            }
            //Console.WriteLine(list[0]);
        }
    }
}
