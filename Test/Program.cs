using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestCsharp
    {
        public static void Main()
        {

            int canha, canhb, canhc;
            Console.Write("\n");
            Console.Write("Kiem tra tam:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");



            Console.Write("Nhap canh a: ");
            canha = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh b: ");
            canhb = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh c: ");
            canhc = Convert.ToInt32(Console.ReadLine());

            if (canha < canhb + canhc && canhb < canha + canhc && canhc < canha + canhb)
            {
                Console.WriteLine("Cac canh tren dat dieu kien tao thanh 1 tam giac");
                if (canha * canha == canhb * canhb + canhc * canhc || canhb * canhb == canha * canha + canhc * canhc || canhc * canhc == canha * canha + canhb * canhb)
                {
                    Console.WriteLine("Day la tam giac vuong");
                }
                else if (canha == canhb && canhb == canhc)
                {
                    Console.Write("Day la tam giac deu.\n");
                }
                else if (canha == canhb || canha == canhc || canhb == canhc)
                {
                    Console.Write("Day la tam giac can.\n");
                }
                else if (canha * canha > canhb * canhb + canhc * canhc || canhb * canhb > canha * canha + canhc * canhc || canhc * canhc > canha * canha + canhb * canhb)
                {
                    Console.Write("Day la tam giac tu");
                }
                else
                {
                    Console.Write("Day la tam giac nhon.\n");
                }
            }

            else
            {
                Console.Write("\n Ba so ban vua nhap ko phai la do dai 3 canh cua 1 tam giac");
            }

            Console.ReadKey();
        }

    }
}
