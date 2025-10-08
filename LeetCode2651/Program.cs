using System;

namespace LeetCode2651
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 輸入
            Console.Write("請輸入到達時間（0~23）：");
            int arrivalTime = int.Parse(Console.ReadLine());

            Console.Write("請輸入延遲時間（小時）：");
            int delayedTime = int.Parse(Console.ReadLine());

            // 2. 處理
            int result = (arrivalTime + delayedTime) % 24;

            // 3. 輸出
            Console.WriteLine("最終時間是：" + result);
        }
    }
}
