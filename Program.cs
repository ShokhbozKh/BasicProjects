using System;
using System.Text;

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
            //7
            /*
            Console.Write("Enter DayOfWeek:");
            int day = int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Does not this day");
                    break;
            }
            */

            //8
            /*
            while (true)
            {
                Console.WriteLine("0.restart, 1.start, 2.stop, 3.exit, ");
                int command = int.Parse(Console.ReadLine());

                if(command == 3)
                {
                    break;
                }

                switch (command)
                {
                    case 0:
                        Console.WriteLine("ReStart");
                        break;
                    case 1:
                        Console.WriteLine("Start");
                        break;
                    case 2:
                        Console.WriteLine("Stop");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Bunday komanda yuq ");
                        break;
                }
            }
            Console.WriteLine("Dastur tugadi...");
            */

            //9 
            /*
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<=n; i++)
            {
                if(i%2==1)
                {
                    Console.Write($"{Math.Pow(i,2)} -> ");
                }
            }
            */

            //10
            /*
            Console.Write("Enter password:");
            string password = Console.ReadLine();

            while (true)
            {
                if(password == "12345")
                {
                    Console.WriteLine("Xush kelibsiz!!!");
                    break;
                }
                Console.Write("Iltimos parolni qaytadan kiriting:");
                password = Console.ReadLine();
            }
            */

            //11
            /*
            int[] arr = new int[4];
            Random rnd = new Random();
            

            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,10);
            }

            int max = arr.Max();
            int min = arr.Min();
            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Min:{arr[0]}\n Max: {arr[arr.Length-1]}\n");
            Console.WriteLine($"Max: {max}\n Min: {min}");
            */

            // 12 -> 3x3
            /*
            Random rnd = new Random();

            int[,] arr = new int[3, 3];

            for(int i=0; i< arr.GetLength(0); i++)
            {
                for(int j=0; j< arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                }
            }

            for(int i=0; i< arr.GetLength(0); i++)
            {
                for(int j=0 ; j< arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
             */

            //13
            /*
            ReverseName("Ali", "Vali");

            static void ReverseName(string fName, string lName )
            {

                Console.WriteLine($"{fName} {lName}");
                string? text = null;

                for(int i=fName.Length-1; i>=0; i--)
                {
                    text += fName[i];
                }
                text += ",";
                for (int i = lName.Length - 1; i >= 0; i--)
                {
                    text += lName[i];
                }
                Console.WriteLine(text);
            }
            */

            //14
            /*
            StringBuilder sb = new StringBuilder();
            
            for(int i=1; i<=5; i++)
            {
                Console.Write($"{i}- matnni kiriting:");
                string text = Console.ReadLine();
                sb.Append( text );

            }
            Console.WriteLine(sb);
            */

            //15
            /*
            Console.WriteLine(IsAge(15));

            static bool IsAge(int age)
            {

                return (age>= 18)? true : false;
            }
            */

            //16
            /*
            Console.WriteLine(ReturnNumber(4,4));

            static int ReturnNumber(int n1, int n2)
            {
                return (n1 > n2) ? n1 : (n1 == n2)? 0: n2;
            }
            */

            //17
            /*
            Hisobla(5);
            Hisobla(12,13);
            Hisobla(49.0);
            */

            //18
            /*
            SalomBer();
            SalomBer("Ali");
            SalomBer("Ali", "Valiyevich");
            */

            // 19
            /*
            Console.WriteLine(Faktorial(5));
            int Faktorial(int n)
            {
                if(n==0)
                {
                    return 1;
                }
                else
                {
                    return n * Faktorial(n - 1);
                }
                    
            }
            */

            //20
            /*
            PrintN(5);

            void PrintN(int n)
            {
                if(n==0)
                {
                    return;
                }
                PrintN(n-1);

                Console.WriteLine(n);
            }
            */

        }
        static void SalomBer()
        {
            Console.WriteLine("Assalomu alaykum");
        }
        static void SalomBer(string name)
        {
            Console.WriteLine($"Assalomu alaykum {name}");
        }
        static void SalomBer(string firstName, string lastName)
        {
            Console.WriteLine($"Assalomu alaykum {firstName}, {lastName}");
        }


        static void Hisobla(int n)
        {
            double result = (Math.Pow(n, 2));
            Console.WriteLine(result);
        }
        static void Hisobla(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        static void Hisobla(double n)
        {
            Console.WriteLine(Math.Sqrt(n));
        }
    }
}