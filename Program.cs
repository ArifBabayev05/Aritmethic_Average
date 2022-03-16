using System;

namespace AritmethicCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double average;
            double[] number = {1,62,3,4,35,6,73};
            for (int i = 0; i < number.Length; i++)
            {
                sum=sum+number[i];
            }
            average = sum/number.Length;
            Console.WriteLine("This Is Average Of Numbers: "+average);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("This Is Sum OF Numbers: "+sum); 
           




        }
    }
}
