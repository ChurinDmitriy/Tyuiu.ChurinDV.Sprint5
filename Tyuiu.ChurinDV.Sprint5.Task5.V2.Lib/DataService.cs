using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            int sum = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToInt32(line) >= 0)
                    {
                        sum += Convert.ToInt32(line);
                        count++;
                    }
                }
            }
            double res = Convert.ToDouble(sum) / Convert.ToDouble(count);
            return Math.Round(res, 3);
        }
    }
}
