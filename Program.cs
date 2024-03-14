using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bai 1
            //Console.Write("Moi nhap so i = ");
            //int i = int.Parse(Console.ReadLine());

            //Console.WriteLine(i%3 == 0 ? "So vua nhap chia het cho 3": "So vua nhap khong chia het cho 3");   
            //Console.ReadKey();

            //bai 2

            //Console.Write("Moi nhap n = ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("Bang nhan {0} ", i);
            //    
            //    for(int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
            //        Console.WriteLine("\n");
            //    }    

            //}
            //Console.ReadKey();

            //bai 3
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int giaithua = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    giaithua = giaithua * i;
            //    sum += giaithua;
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();


            //bai 4
            //int n = int.Parse(Console.ReadLine());

            //int i = 0;
            //while (i*i <= n) {
            //if (i*i ==n)
            //    {
            //        Console.WriteLine("n la so chinh phuong");
            //    }
            //i++;

            //}

            //Console.ReadKey();

            //bai 5
            //Console.Write("moi nhap vao nam: ");
            //string nam1 = Console.ReadLine();
            //Console.Write("moi nhap vao thang: ");
            //string thang1 = Console.ReadLine();
            //int thang = int.Parse(thang1);
            //int nam = int.Parse(nam1);  
            //if (thang >= 1 && thang <= 12)
            //{
            //    switch (thang)
            //    {

            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("So ngay trong thang la 31 ");
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("So ngay trong thang la 30 ");
            //            break;

            //        case 2:
            //            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
            //            {
            //                Console.WriteLine("Thang 2 nam nhuan co 29 ngay ");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Thang 2 nam khong nhuan co 28 ngay ");
            //            }
            //            break;

            //    }

            //}
            //else
            //{
            //    Console.Write("Thang ban nhap vao không hop le");
            //}    
            //Console.ReadKey();


            //bai 6
            //Console.Write("Nhap so n: ");
            //int n = int .Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <=n; i++)
            //{
            //    sum += i * i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //bai 7 
            //Console.Write("nhap so n: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;    
            //for (int i = 1; i <= n; i++) 
            //{
            //    if(i%2 !=0)
            //    {
            //        sum += i;
            //    }    
            //}

            //Console.WriteLine(sum);
            //Console.ReadLine();

            //bai 8
            //Console.WriteLine("Nhap so n: ");
            //int n = int.Parse(Console.ReadLine());
            //bool nguyento = true;
            //if (n < 2)
            //{
            //    nguyento = false;

            //}
            //for (int i = 2; i < n/2 ; i++) 
            //{
            //    if (n%i == 0) { nguyento =false; break; }

            //}
            //if (nguyento)
            //{
            //    Console.WriteLine("Day la so nguyen to");

            //}
            //else
            //{
            //    Console.WriteLine("Khong phai so nguyen to");
            //}
            //Console.ReadKey();    

            //bai 9 
            //Console.Write("Moi nhap n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            //bai 10 
            //Console.Write("Moi nhap n: ");
            //int n = int.Parse(Console.ReadLine());
            //int so_1 = 0;
            //int so_2 = 1;
            //int so_3;

            //Console.Write("Day Fibonacci: " + so_1 + " " + so_2 + " ");

            //for (int i = 2 ; i < n; i++) {
            //    so_3 = so_1 + so_2;
            //    Console.Write(so_3 + " ");
            //    so_1 = so_2;
            //    so_2 = so_3;
            //}
            //Console.ReadKey();
        }

    }
}
