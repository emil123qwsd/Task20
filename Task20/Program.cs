using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//        В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:

//-       метод получает входным параметром переменную типа double;

//-       метод возвращает значение типа double, которое является результатом вычисления.



//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

//-       длину окружности по формуле D = 2 * π * R;

//-       площадь круга по формуле S = π* R²;

//-       объем шара.Формула V = 4 / 3 * π * R³.
namespace Task20
{
    class Program

    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус r=");
            double rad = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LengthС;
            double l = myDelegate(rad);
            Console.WriteLine("Длина окружности равна {0}",l);
            Console.WriteLine();
            
            Console.WriteLine("Введите радиус r=");
            rad = Convert.ToDouble(Console.ReadLine());
            myDelegate = SquareC;
            l = myDelegate(rad);
            Console.WriteLine("Площадь окружности равна {0}", l);
            Console.WriteLine();

            Console.WriteLine("Введите радиус r=");
            rad = Convert.ToDouble(Console.ReadLine());
            myDelegate = VolumeC;
            l = myDelegate(rad);
            Console.WriteLine("Объем окружности равен {0}", l);
            Console.WriteLine();
            Console.ReadKey();
        }
        static double LengthС(double r) => 2*Math.PI*r;
        static double SquareC(double r) => Math.PI * Math.Pow(r,2);
        static double VolumeC(double r) => (4.0/3)*Math.PI * Math.Pow(r, 3);
    }
}
