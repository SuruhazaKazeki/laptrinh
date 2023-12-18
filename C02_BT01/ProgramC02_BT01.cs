using System; //khai báo không gian tên của visual
//Bài tập 01: 
//Viết chương trình nhập thông tin sinh viên gồm họ tên, năm sinh, nơi sinh, điểm trung bình rồi in ra màn hình.


namespace C02_BT01 //Đặt tên không gian cho BT01
{
    class ProgramC02_BT01 //Đặt tên lớp
    {
        static void Main(string[] args)//Phương thức (hàm) của chương trình sẽ thực thi đầu tiên khi chạy chương trình
        {
            //Bước 1: Khai báo biến hoặc hằng
            string hoTen;
            int ngaySinh;
            string noiSinh;
            float diemTB;
            //Bước 2: Nhập liệu
            Console.WriteLine("* nhap thong tin ca nhan *");
            Console.Write("\t- Ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("\t- Ngay sinh: ");
            ngaySinh = int.Parse(Console.ReadLine());
            Console.Write("\t- Noi sinh: ");
            noiSinh = Console.ReadLine();
            Console.Write("\t- Diem Trung binh: ");
            diemTB =float.Parse(Console.ReadLine());
            //Bước 3: xử lý % tính toán
            //Bước 4: xuất kết quả
            Console.Clear();
            Console.WriteLine("* Xuat thong tin sinh vien *");
            Console.WriteLine("\t- Ho ten: {0}", hoTen);
            Console.WriteLine("\t- Ngay sinh: {0}", ngaySinh);
            Console.WriteLine("\t- Noi sinh: {0}", noiSinh);
            Console.WriteLine("\t- Diem trung binh: {0:0.0}", diemTB);
            //Bước 5: kết thúc & xem kết quả chạy chương trình
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ban da ket thuc chuong trinh!");
            Console.ReadLine();
        }
    }
}
