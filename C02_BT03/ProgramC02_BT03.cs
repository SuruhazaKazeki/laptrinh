using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_BT03
{
    class ProgramC02_BT03
    {
        static void Main(string[] args)
        {
            // B1: Khai bao
            double a, b, tong, hieu, tich, thuong, x;
            // B2: Nhap lieu
            Console.WriteLine("* Nhap so lieu *");
            Console.Write("\t- a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\t- b = ");
            b = double.Parse(Console.ReadLine());
            // B3: tinh toan
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = 0;
            x = 0;
            if (b != 0)
                x = a / b;
            else
                Console.WriteLine("! ban khong the chia cho so nay!");
            // B4: xuat
            Console.WriteLine("* Ket qua *");
            Console.WriteLine("Tong: {0} + {1} = {2}", a, b, tong);
            Console.WriteLine("Hieu: {0} - {1} = {2}", a, b, hieu);
            Console.WriteLine("Tich: {0} * {1} = {2}", a, b, tich);
            if (b != 0)
                Console.WriteLine("Thuong: {0} / {1} = {2:0.00}", a, b, x);
            else
            // B5: Ket thuc
            Console.WriteLine("---------------------------------");
            Console.WriteLine("* Ket thuc *");
            Console.ReadLine();
        }
    }
}
