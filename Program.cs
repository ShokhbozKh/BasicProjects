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
            /*
            Console.Write("First Store: ");
            double firstOfPrice = double.Parse(Console.ReadLine());
            Console.Write("Second Store: ");
            double secondOfPrice = double.Parse(Console.ReadLine());
            Console.Write("Third Store: ");
            double thurdOfPrice = double.Parse(Console.ReadLine());

            double sum = firstOfPrice + secondOfPrice + thurdOfPrice;
            double avg = sum / 3;

            double qimmatMahsulot = (firstOfPrice > secondOfPrice && firstOfPrice > thurdOfPrice) ? firstOfPrice :
                (secondOfPrice > firstOfPrice && secondOfPrice > thurdOfPrice) ? secondOfPrice : thurdOfPrice;

            Console.WriteLine($"{sum} umumiy xarajat \n" +
                $"{avg} urtacha xarajat\n" +
                $"{qimmatMahsulot} qimmat mahsulot narxi \n");
            */

            //3
            /*
            Console.Write("Enter sum: ");
            string price1 = Console.ReadLine();
            Console.Write("Soliq foizi: ");
            string price2 = Console.ReadLine();

            double oylik = Convert.ToDouble(price1) * (100 - Convert.ToDouble(price2))/100;

            Console.WriteLine($"Your balance: {oylik}");
            */


        }
    }
}