using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_BT02
{
    class ProgramC02_BT02
    {
        static void Main(string[] args)
        {
            string ho, ten, gioiTinh;
            DateTime ngaySinh;
            byte tuoi;
            Console.WriteLine("* Nhap thong tin ca nhan");
            Console.Write("\t- Ho: ");
            ho = Console.ReadLine();
            Console.Write("\t- ten: ");
            ten = Console.ReadLine();
            Console.Write("\t- Ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\t- Gioi tinh: ");
            gioiTinh = Console.ReadLine();
            tuoi = (byte) (DateTime.Today.Year - ngaySinh.Year);
            Console.WriteLine("* xuat thong tin ca nhan *");
            Console.WriteLine("\t- Ho: {0} {0}", ho,ten);
            Console.WriteLine("\t- Ngay sinh: {0}", ngaySinh);
            Console.WriteLine("\t- gioi tinh: {0}", gioiTinh);
            Console.WriteLine("\t- Tuoi: {0}",tuoi);
            Console.WriteLine("-----------------------");
            Console.WriteLine("* ban da ket thuc chuong trinh *");
            Console.ReadLine();


        }
    }
}
