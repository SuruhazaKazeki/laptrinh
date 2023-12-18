using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_BT04
{
    class ProgramC02_BT04
    {
        // viết chương trình nhập tên sản phẩm, số lượng và đơn giá. tính tiền và thuế giá trị gia tăng, biết:
        // a. Tiền = số lượng * đơn giá
        // b. Thuế giá trị gia tăng = 10% tiền
        static void Main(string[] args)
        {
            //Bước 1: khai báo biểu
            // Nhap
            string tenSanPham;
            int soLuong;
            Double donGia;
            // Xuat
            int thanhTien;
            double thueGTGT;
            //Bước 2: Nhập liệu
            Console.WriteLine(" * Nhap thong tin san pham: *");
            Console.Write("\t- Ten san pham: ");
            tenSanPham = Console.ReadLine();
            Console.Write("\t- So luong: ");
            soLuong = int.Parse(Console.ReadLine());
            Console.Write("\t- Don gia: ");
            donGia = double.Parse(Console.ReadLine());
            //Bước 3: xử lý tính toán
            thanhTien = (int)(soLuong * donGia);
            thueGTGT= 0.1*thanhTien;
            //Bước 4: Xuất kết quả
            Console.WriteLine("* Ket qua tinh toan thanh tien va thueGTGT cua san pham {0}", tenSanPham);
            Console.WriteLine("\t- Thanh tien = {0:0,00#} VND", thanhTien);
            Console.WriteLine("\t- Thue GTGT = {0:0,00#,00} VND", thueGTGT);
            //Bước 5: Kết thúc
            Console.WriteLine("======================================================");
            Console.WriteLine("* Ket thuc *");
            Console.ReadKey();
        }
    }
}
