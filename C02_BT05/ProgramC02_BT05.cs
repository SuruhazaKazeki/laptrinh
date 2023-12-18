using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_BT05
{
    class ProgramC02_BT05
    {
        //Viết chương trình nhập điểm thi và hệ số 3 môn Toán, Lý, Hóa của một SV. tính điểm TB của SV đó.
        static void Main(string[] args)
        {
            //Bước 1: Khai báo biến.
            string hoTenSV, maSoSV;
            double toan, ly, hoa, diemTB, heSoToan, heSoLy, heSoHoa;
            //Bước 2: Nhập liệu.
            // nhap thong tin ca nhan
            Console.WriteLine("* Sinh vien nhap thong tin *");
            Console.Write("\t- MSSV: ");
            maSoSV = Console.ReadLine();
            Console.Write("\t- Ho va ten: ");
            hoTenSV = Console.ReadLine();
            // nhap diem so
            Console.WriteLine("* Sinh vien nhap diem so *");
            Console.WriteLine("\t- mon toan: ");
            Console.Write("\t\t+ Diem = ");
            toan = double.Parse(Console.ReadLine());
            Console.Write("\t\t+ He so = ");
            heSoToan = double.Parse(Console.ReadLine());
            Console.WriteLine("\t- Mon ly: ");
            Console.Write("\t\t+ Diem = ");
            ly = double.Parse(Console.ReadLine());
            Console.Write("\t\t+ He so = ");
            heSoLy = double.Parse(Console.ReadLine());
            Console.WriteLine("\t- mon hoa: ");
            Console.Write("\t\t+ Diem = ");
            hoa = double.Parse(Console.ReadLine());
            Console.Write("\t\t+ He so = ");
            heSoHoa = double.Parse(Console.ReadLine());

            //Bước 3: Xử lý tính toán.
            diemTB = (toan * heSoToan + ly * heSoLy + hoa * heSoHoa) / (heSoToan + heSoLy + heSoHoa);
            //Bước 4: Xuất.
            Console.WriteLine(" Sinh vien {0} MSSV {1}", hoTenSV, maSoSV);
            Console.WriteLine("\t- Diem toan: {0} \t-Diem ly: {1} \t- Diem hoa: {2}", toan, ly, hoa);
            Console.WriteLine("\t- Diem trung binh = {0:0.0}", diemTB);
            //Bước 5: Kết thúc.
            Console.WriteLine("==========================================");
            if (diemTB >= 5)
                Console.WriteLine("* ban da du diem len lop *");
            else
                Console.WriteLine("* Chuc ban may man lan sau =)) *");
            Console.WriteLine("* Cam on ban *");
            Console.ReadKey();
        }
    }
}
