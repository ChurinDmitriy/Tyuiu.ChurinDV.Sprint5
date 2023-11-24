using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ChurinDV.Sprint5.Task6.V14.Lib;

namespace Tyuiu.ChurinDV.Sprint5.Task6.V14
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
            Console.WriteLine("* УСЛОВИЕ: Дан файл С:/DataSprint5/InPutDataFileTask6V14.txt              *");
            Console.WriteLine("* в котором есть набор символьных данных.                                 *");
            Console.WriteLine("* Найти количество знаков препинания в заданной строке.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint5\Tyuiu.ChurinDV.Sprint5.Task6.V14\bin\Debug\InPutDataFileTask6V14.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество знаков препинания = " + res);
            Console.ReadKey();
        }
    }
}
