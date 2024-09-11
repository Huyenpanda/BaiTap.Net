using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap04_09
{
    internal class BaiTap
    {
        public void Bai1()
        {
            //Bài 1: Tạo mảng số nguyên và tính tổng
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập các phần tử trong mảng: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            Console.WriteLine("Tổng các phần tử trong mảng là: {0}", tong);
            Console.ReadKey();
        }
        public void Bai2()
        {
            //Bài 2: Đếm số lượng ký tự trong chuỗi
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một chuỗi: ");
            string input = Console.ReadLine();
            int dem = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char kytu = input[i];
                if (char.IsLetterOrDigit(kytu))
                {
                    dem++;
                }
            }
            Console.WriteLine("Số lượng kí tự trong chuỗi là: " + dem);
            Console.ReadKey();
        }
        public void Bai3()
        {
            //Bài 3: Tìm phần tử lớn nhất trong mảng
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập các phần tử trong mảng: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Phần tử trong mảng là: {0}", max);
            Console.ReadKey();
        }
        public void Bai4()
        {
            //Bài 4: Đảo ngược chuỗi
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một chuỗi: ");
            string input = Console.ReadLine();

            char[] mangKyTu = input.ToCharArray();
            Array.Reverse(mangKyTu);
            string ChuoiDaoNguoc = new string(mangKyTu);
            Console.WriteLine("Chuỗi đảo ngược: " + ChuoiDaoNguoc);
            Console.ReadKey();
        }
        public void Bai5()
        {
            //Bài 5: Kiểm tra mảng đối xứng
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            bool kt = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[n - i - 1])
                {
                    kt = false;
                    break;
                }

            }
            if (kt)
            {
                Console.WriteLine("Mảng đối xứng");
            }
            else
            {
                Console.WriteLine("Mảng không đối xứng");
            }
            Console.ReadKey();
        }
        public void Bai6()
        {
            //Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một chuỗi: ");
            string input = Console.ReadLine();

            char[] mangKyTu = input.ToCharArray();
            Console.WriteLine("Nhập ký tự cần đếm: ");
            char KyTu = char.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < mangKyTu.Length; i++)
            {
                if (mangKyTu[i] == KyTu) dem++;
            }
            Console.WriteLine("Ký tự {0} xuất hiện {1} lần", KyTu, dem);
            Console.ReadKey();


        }

    }
}
