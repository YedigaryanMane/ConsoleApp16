using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        public static void SumOfElements(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        public static void PrintValue()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void PrintGrades(int n)
        {
            if (n > 0 && n <= 20)
            {
                Console.WriteLine("A");
            }
            else if (n > 20 && n <= 40)
            {
                Console.WriteLine("B");
            }
            else if (n > 40 && n <= 60)
            {
                Console.WriteLine("C");
            }
            else if (n > 60 && n <= 80)
            {
                Console.WriteLine("D");
            }
            else if (n > 80 && n <= 100)
            {
                Console.WriteLine("E");
            }
        }

        public static void ReturnVowel(char c)
        {
            switch (c)
            {
                case 'a':
                case 'A':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'u':
                case 'U':
                case 'e':
                case 'E':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("It is symbol");
                    break;

            }
        }

        public static int ReturnSmallest(int a, int b, int c)
        {
            if (a > b && b < c)
            {
                return b;
            }
            else if (b > a && a < c)
            {
                return a;
            }
            else
            {

                return a;
            }
        }

        public static void ReturnEvenorOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void ReturnType(string str)
        {
            if (str == null)
            {
                Console.WriteLine("Null");
            }
            else if (str == "0")
            {
                Console.WriteLine("0");
            }
            else if (str == " ")
            {
                Console.WriteLine(" ");
            }
        }

        public static void PrintSeason(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Winter");
                    break;
                case 2:
                    Console.WriteLine("Spring");
                    break;
                case 3:
                    Console.WriteLine("Summer");
                    break;
                case 4:
                    Console.WriteLine("Autumn");
                    break;

            }
        }

        public static void Print(string str)
        {
            switch (str)
            {
                case "Red":
                    Console.WriteLine("Stop");
                    break;
                case "Yellow":
                    Console.WriteLine("Wait");
                    break;
                case "Green":
                    Console.WriteLine("Go");
                    break;
            }
        }

        public static void PrintNum(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine(" Ten");
                    break;
            }
        }

        public static void PrintOdd()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSquare()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        public static void SumEvenNum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        public static void ReturnMul(int n)
        {
            int k = 1;
            while (n > 0)
            {
                k *= n;
                n--;
            }
            Console.WriteLine(k);
        }

        public static void PrintPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }

        public static void FindGCD(int n, int n1)
        {
            int gdc = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && n1 % i == 0)
                {
                    if (gdc < i)
                    {
                        gdc = i;
                    }
                }
            }
            Console.WriteLine(gdc);
        }

        public static void FindLCM(int n, int n1)
        {
            int lcm = 0;

            for(int i = n; i >=n*n1; i++)
            {
                if(i%n == 0 && i %n1 == 0)
                {
                    if(lcm < i)
                    {
                        lcm = i;
                    }
                }
            }
            Console.WriteLine(lcm);
        }
        
        public static bool PrintPerfectNum(int n)
        {
            int sum = 0;
            for(int i = 1; i <n; i++)
            {
                if(n%i == 0)
                {
                    sum += i;

                    if(sum == n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int ReturnElementAvg(int[] arr)
        {
            int sum = 0;
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                count++;
            }

            return sum / count;
        }

        public static string PlusStrings(string str,string str1)
        {
            return str + str1;
        }

        public static int ReturnDigCount(int n)
        {
            int count = 0;
            while(n > 0)
            {
                int y = n % 10;
                count++;
                n/= 10;
            }

            return count;
        }
        public static bool ChekArm(int n)
        {
            double sum = 0;
            int c = n;
            while(n > 0)
            {
                int x = n % 10;
                sum += Math.Pow(x, ReturnDigCount(c));
                n/= 10;
            }

            if(sum == c)
            {
                return true ;
            }

            return false ;
        }

        public static void ReturnPer(int a,int b,double r)
        {
            int Per = 2*(a+b);
            double M_PI = 3.14;
            double Per1 = 2 * M_PI * r;
            Console.WriteLine(Per);
            Console.WriteLine(Per1);
        }

        public static int ReturnLongestLength(string[] str)
        {
            int max = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i].Length > max)
                {
                    max = str[i].Length;
                }
            }

            return max;
        }

        public static void Sorted(int[] arr)
        {
            int tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++) 
                {
                    if(arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            for(int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void Return(int[] arr)
        {
            int tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            Console.WriteLine(arr[1]);
        }

        public static void Sorted1(string[] str)
        {
           Array.Sort(str);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
        public static void Append(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Anin gnac antar sunk havaqelu");
            }

            File.AppendAllText(path, "Bayc antarum sunk chkar");
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3 };
            //SumOfElements(arr);

            //PrintValue();

            //int n = Convert.ToInt32(Console.ReadLine());
            //PrintGrades(n);

            //char c = Convert.ToChar(Console.ReadLine());
            //ReturnVowel (c);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //ReturnSmallest(a, b, c);

            //int n = Convert.ToInt32(Console.ReadLine());
            //ReturnEvenorOdd(n);

            //string str = Console.ReadLine();
            //ReturnType(str);

            //int n = Convert.ToInt32(Console.ReadLine());
            //PrintSeason(n);

            //string str = Console.ReadLine();
            //Print(str);

            //int n = Convert.ToInt32(Console.ReadLine());
            //PrintNum(n);

            // PrintOdd();

            //PrintSquare();

            //int n = Convert.ToInt32(Console.ReadLine());
            //SumEvenNum(n);

            //int n = Convert.ToInt32(Console.ReadLine());
            //ReturnMul(n);

            //int n = Convert.ToInt32(Console.ReadLine());
            //PrintPrime(n);

            //int n = Convert.ToInt32(Console.ReadLine());
            //PrintTriangle(n);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //FindGCD(n, n1);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //FindLCM(n, n1);

            //int n = Convert.ToInt32(Console.ReadLine());
            //bool x = PrintPerfectNum(n);
            //Console.WriteLine(x);

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int x = ReturnElementAvg(arr);
            //Console.WriteLine(x);

            //string str = Console.ReadLine();
            //string str1 = Console.ReadLine();
            //string s = PlusStrings(str, str1);
            //Console.WriteLine(s);

            //int n = int.Parse(Console.ReadLine());
            //bool x = ChekArm(n);
            //Console.WriteLine(x);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //double r = Double.Parse(Console.ReadLine());
            //ReturnPer(a, b, r);

            //string[] str = { "aaa", "hffhh", "ghyj" };
            //int x = ReturnLongestLength(str);
            //Console.WriteLine(x);

            //int[] arr = { 2, 1, 3 };
            //Sorted(arr);

            //int[] arr = { 2, 1, 3 };
            //Return(arr);

            //string path = @"C:\Users\user\Desktop\New folder (6)\home.txt";
            //Append(path);

            string[] str = { "abba", "j", "m", "l", "b" };
            Sorted1(str);
            Console.ReadLine();
        }
    }
}
