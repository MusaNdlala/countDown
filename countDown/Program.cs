using System;

namespace countDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10,1);
            Console.Read();
        }
        static void Countdown(Int16 intStartNum, Int16 intEndNum)
        {
            
            do
            {
                Console.WriteLine(intStartNum--);
            } while (intStartNum >= intEndNum);

        }
    }
}
