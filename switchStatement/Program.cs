using System;
namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 52;
            switch (theVal)
            {
                case 50:
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                    Console.WriteLine("theVal is 51");
                    break;
                case 52:
                    Console.WriteLine("theVal is between 52 and 54");
                    break;
                case 53:
                    Console.WriteLine("theVal is between 52 and 54");
                    break;
                case 54:
                    Console.WriteLine("theVal is between 52 and 54");
                    break;
                default:
                    Console.WriteLine("theVal is something different");
                    break;
            }
        }
    }
}