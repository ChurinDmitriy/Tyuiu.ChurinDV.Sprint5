using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChurinDV.Sprint5.Task5.V2.Lib;
using System.IO;


namespace Tyuiu.ChurinDV.Sprint5.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Чурин Дмитрий Владимирович | ИСТНб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан файл С:/DataSprint5/InPutDataFileTask5V2.txt               *");
            Console.WriteLine("* в котором есть набор значений Найти среднее всех положительных значений *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint5\Tyuiu.ChurinDV.Sprint5.Task5.V2\bin\Debug\InPutDataFileTask5V2.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Среднее значение положительных значений файла = " + res);
            Console.ReadKey();
        }
    }
}
