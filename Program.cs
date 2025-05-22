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

            //4
            /*
            Console.Write("Enter any Number: ");
            string number = Console.ReadLine();
            bool resultInt = int.TryParse(number, out int resultI);
            bool resultDouble = double.TryParse(number, out double resultD);

            if (resultInt)
            {
                Console.WriteLine($"this is int type {Math.Pow(resultI, 2)}");
            }
            else if (resultDouble)
            {
                Console.WriteLine($"this is double type {Math.Sqrt(resultD)}");
            }
            else
            {
                Console.WriteLine("Error ");
            }

            */

            //5
            // simple if/else and ternary

            /*
            Console.Write("Enter your Greate: ");
            int greate = int.Parse(Console.ReadLine());
            */
            /*
            string result = (greate >= 90 && greate <= 100) ? "A" : (greate >= 80 && greate <= 89) ? "B" : (greate >= 70 && greate <= 79) ? "C" : "F";
            Console.WriteLine(result);
            */
            /*
            if(100<= greate && 90<= greate)
            {
                Console.WriteLine("A");
            }
            else if(greate>= 80 && greate<=89)
            {
                Console.WriteLine("B");
            }
            else if(greate>=70 && greate<=79)
            {
                Console.WriteLine("C");
            }
            else if(greate>=60 && greate<=69)
            {
                Console.WriteLine("D");
            }
            else if(greate>=0 && greate<=59)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Xatolik");
            }
            */
            // 6
            /*
            Console.Write("Enter two numbers with space: ");
            int[] numbers  = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            if (numbers[0]>numbers[1])
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers[0]<numbers[1])
            {
                Console.WriteLine(numbers[1]);
            }
            else
            {
                Console.WriteLine($"{numbers[0]} == {numbers[1]}");
            }
            */

            //7
        }
    }
}