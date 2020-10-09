using System.IO;
using System;
namespace masha
{
    public class integer
    {


        static void Main()
        {
            For1();
        }
        static void For1()
        {
            int K = 7;
            int N = 3;
            for (int i = 0; i <= N; i++)
            {
                Console.Write(K);
            }
        }

        static void For4()
        {
            int A = 3;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(A);
                Console.Write("; ");
                A++;
            }
        }

        public static int For8(int A, int B)
        {
            A = 1;
            B = 4;
            int C = 1;
            for (int i = 0; i < B; i++)
            {
                C *= A;
                A++;
            }
            return(C);
        }

        public static double For12(int N)
        {
             N = 3;
            double A = 1.1;
            double m = 1.2;
            if (N > 0)
            {
                for (int i = 1; i < N; i++)
                {
                    A *= m;
                    m += 0.1;
                }
                return(A);
            }
            else
            {
                return (0);
            }
        }

        static void For16()
        {
            int N = 3;
            double A = 2;
            double A1 = 1;
            int s = 1;
            if (N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    A1 = A1 * A;
                    Console.Write(A1);
                    Console.Write(" ");
                    Console.WriteLine(s);
                    s++;
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }

        static void For20()
        {
            int N = 4;
            double A = 1;
            double m = 1;
            double B = 0;
            if (N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    A = A * m;
                    m++;
                    Console.WriteLine(A);
                    B = B + A;
                }
                Console.Write(B);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        static void For24()
        {
            int n = 1, z = 1;
            double x = 3, x1 = 1, factorial = 1, sum = 1;
            for (int i = 1; i <= 2 * n; ++i)
            {
                factorial *= i;
                if (i % 2 == 0)
                {
                    x1 = x * x1;
                    z = (-z);
                    sum += z * ((x1 * x1) / factorial);

                }
            }
            Console.WriteLine(sum);


        }
        static void For28()
        {
            float Rez = 1, a = 1, Rez1 = 1, Rez2 = 1;
            int N = 4;
            for (int i = 1; i < N; i++)
            {
                Rez1 *= 2 * i - 3;
                Rez2 *= 2 * i;
                a *= -1;
                Rez += Rez1 * a / Rez2;
            }
            Console.WriteLine(Rez);
        }
        static void For32()
        {
            float A = 1;
            int N = 5;
            for (int i = 1; i < N; i++)
            {
                A = (A + 1) / i;
                Console.WriteLine(A);
            }

        }
        public static int While1(int A, int B)
        {
             A = 5;
             B = 2;
            while (A > B)
            {
                A -= B;
            }
            return(A);
        }
       public static int while4(int N)
        {
            N = 6;
            if (N % 3 == 0!)
            {
                N %= 3;
                return (1);
            }
            else
                return (0);
        }
        static void While8()
        {
            int N = 4, K = 1;
            while (K * K < N)
            {
                K++;
            }
            Console.WriteLine(K);
        }
        static void While12()
        {
            double n, k, l;
            n = 76;
            k = 0;
            l = 0;
            while (l + k + 1 >= n)
                k++;
            l = l + k;
            Console.WriteLine(k);
            Console.WriteLine(l);
        }

        static void While16()
        {
            double p, d, s, k;
            p = 16;
            k = 1;
            d = 10;
            s = 10;
            while (s <= 200)
                k++;
            d = d + d * p / 100;
            s = s + d;
            Console.WriteLine(k);
            Console.WriteLine(s);
        }
        static void While20()
        {
            int n;
            bool c;
            c = false;
            n = 5;
            while (n > 0)
            {
                if (n / 10 == 2)
                {
                    c = true;
                    n = n / 10;
                }
            }

            Console.WriteLine(c);
        }

        static void While24()
        {
            double n, f, f1, f2;
            n = 18;
            f1 = 1;
            f = 0;
            f2 = 1;
            while (f < n)
                f = f2 + f1;
            f2 = f1;
            f1 = f;
            Console.WriteLine(f = n);

        }

        static void While28()
        {
            double k, ak1, ak, e;
            e = 10;
            ak1 = 0;
            ak = 2;
            k = 1;
            while (Math.Abs(ak - ak1) >= e)
                k++;
            ak1 = ak;
            ak = 2 + 1 / ak1;
            Console.WriteLine(k);
            Console.WriteLine(ak);
            Console.WriteLine(ak1);
        }
    }
}




