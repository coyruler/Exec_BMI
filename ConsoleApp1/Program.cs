using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// 計算 BMI
        /// BMI值計算公式:    BMI = 體重(公斤) / 身高2(公尺2)
        /// 體重過輕 BMI ＜ 18.5
        /// 正常範圍 18.5≦BMI＜24
        /// 過重：24≦BMI＜27
        /// 輕度肥胖：27≦BMI＜30
        /// 中度肥胖：30≦BMI＜35
        /// 重度肥胖：BMI≧35　
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的身高(公分)");
            string value = Console.ReadLine();
            float height = float.Parse(value);
            Console.WriteLine("請輸入你的體重(公斤)");
            value = Console.ReadLine();
            float weight = float.Parse(value);

            float bmi = weight / (height / 100)/(height / 100);

            if (bmi >= 35)
            {
                Console.WriteLine("重度肥胖");
            }
            else if(bmi >=30)
            {
                Console.WriteLine("中度肥胖");
            }
            else if (bmi >= 27)
            {
                Console.WriteLine("輕度肥胖");
            }
            else if (bmi >= 24)
            {
                Console.WriteLine("過重");
            }
            else if (bmi >= 18.5)
            {
                Console.WriteLine("正常範圍");
            }
            else
            {
                Console.WriteLine("體重過輕");
            }
        }
    }
}
