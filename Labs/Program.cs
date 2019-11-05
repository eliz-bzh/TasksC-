using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Labs.ChangeConsoleColor("\tЭти люди говорили, что между ранними легендами есть существенное сходство, в том числе - в деталях, и что во многом вермонтские холмы остаются до конце не исследованными, так что было бы неразумно походя отметать вероятность наличия там загадочных обитателей; нельзя было убедить моих упрямых друзей и в том, что, как известно, все мифы имеют общую структуру и объясняются одним и тем же типом искажения реальности, порожденным ранней стадией, развития мышления человека.\n\tНе было смысла демонстрировать таким оппонентам, что вермонтские мифы по существу мало отличались от тех всеобщих легенд о природной персонификации, которые наполнили античный мир фавнами, дриадами и сатирами, предположили существование калликанзараев в Греции и дали диким уэльсцам и ирландцам возможность предположить существование странных, маленьких и тщательно спрятанных племен троглодитов и обитателей земляных нор.Бесполезно было также напоминать им о вере непальских горных племен в существование страшного Ми - Го или «Отвратительного Снежного Человека», таящегося посреди ледяных и горных шпилей Гималаев.");
            Labs.LengthSquare(4);
            Console.WriteLine(Labs.ConvertByteKilobytes(5011));
            Console.WriteLine(Labs.geometricProgression(124));
            Labs.f4();
            Console.WriteLine(Labs.triangle(1,1,1));
            Console.WriteLine(Labs.F7(0,3,4));
            Labs.F8();

            //2
            Console.WriteLine(Labs.f1(0));

            double[] array = new double[4];
            Console.WriteLine(Dasha.SubFirstSecond(array));
            

            int[,] mat = new int[3,3]
            {
                                { 1, 2, 0 },
                               { 1, 0, 3 },
                               { 0, 2, 3 }
            };
            int[,] m = new int[3, 3]
                {
                               { 1, 2, 0 },
                               { 1, 0, 3 },
                               { 0, 2, 3 }
                            };

            Console.WriteLine(Dasha.MulMatrix(mat, m));
            Dasha.SumGreaterOfArif(4);*/


            /*Console.WriteLine(LizKPiIP.Conversion("hello", 8));
            Console.WriteLine(LizKPiIP.Convertion("Hello", 5));*/

            DateTime[] arr = new DateTime[10];
            //Console.WriteLine(LizKPiIP.fillArray(arr, 10));
            //LizKPiIP.f(arr, 10);
            Console.WriteLine(LizKPiIP.ConverTo(4));
            Console.ReadLine();
        }
    }
}
