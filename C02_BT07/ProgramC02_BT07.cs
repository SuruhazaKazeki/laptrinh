using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_BT07
{
    class ProgramC02_BT07
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, soNut;
            Console.WriteLine("* Nhap so xe *");
            Console.Write("\t- So thu nhat = ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\t- So thu hai = ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("\t- So thu ba = ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("\t- So thu bon = ");
            n4 = int.Parse(Console.ReadLine());
            soNut = n1 + n2 + n3 + n4;
            Console.WriteLine("* Ket qua *");
            Console.WriteLine("\t- Bien so xe = {0}{1}{2}{3}", n1, n2, n3, n4);
            Console.WriteLine("\t- So nut = {0}", soNut);
            Console.WriteLine("====================================================== ");
            Console.WriteLine("\t Ket thuc chuong trinh ");
            Console.ReadLine();
        }
    }
}
