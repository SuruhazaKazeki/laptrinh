using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_BT06
{
    class ProgramC02_BT06
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159265359;
            double R,chuVi,dienTich;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("* Nhap du lieu hinh tron *");
            Console.Write("\t- R= ");
            R = double.Parse(Console.ReadLine());
            chuVi = R * 2 * PI;
            dienTich = R * R * PI;
            Console.WriteLine("* Ket qua *");
            Console.WriteLine("\t Chu vi hinh tron = {0:0.00} ", chuVi);
            Console.WriteLine("\t Dien tich hinh tron = {0:0.00} ", dienTich);
            Console.WriteLine("====================================================== ");
            Console.WriteLine("\t Ket thuc chuong trinh ");
            Console.ReadLine();


        }
    }
}
