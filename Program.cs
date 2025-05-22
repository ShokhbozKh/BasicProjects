using System;

namespace BasicProject1
{
    public class Program
    {
        public static void Main()
        {
            //1
            /*
            Console.Write("Yoshingiz: ");
            int age = int.Parse(Console.ReadLine());
            int FiveYearsLater = age + 5;
            int PensiyaYoshi = 60 - age;

            if(PensiyaYoshi > 0)
            {
                Console.WriteLine($"{PensiyaYoshi} yildan keyin pensiyaga chiqasiz ");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(PensiyaYoshi)} yildan oldin pensiyaga chiqqansiz ");
            }
               */

            //2
            Console.Write("First Store: ");
            double firstOfPrice = double.Parse(Console.ReadLine());
            Console.Write("Second Store: ");
            double secondOfPrice = double.Parse(Console.ReadLine());
            Console.Write("Thurd Store: ");
            double thurdOfPrice = double.Parse(Console.ReadLine());

            double sum = firstOfPrice + secondOfPrice + thurdOfPrice;
            double avg = sum / 3;

            double qimmatMahsulot = (firstOfPrice > secondOfPrice && firstOfPrice > thurdOfPrice) ? firstOfPrice :
                (secondOfPrice > firstOfPrice && secondOfPrice > thurdOfPrice) ? secondOfPrice : thurdOfPrice;

            Console.WriteLine($"{sum} umumiy xarajat" +
                $"{avg} urtacha xarajat" +
                $"{qimmatMahsulot} qimmat mahsulot narxi");

            

        }
    }
}