using System;

namespace LeetCode2651
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 輸入
            Console.Write("請輸入到達時間（0~23）："); //輸出到達時間提示
            int arrivalTime = int.Parse(Console.ReadLine()); // 從使用者輸入讀取字串，並用 int.Parse 將其轉換成整數後指定給 arrivalTime

            Console.Write("請輸入延遲時間（小時）："); //輸出到延遲間提示 
            int delayedTime = int.Parse(Console.ReadLine()); // 從使用者輸入讀取字串，並用 int.Parse 將其轉換成整數後指定給 delayedTime

            // 2. 處理
            int result = (arrivalTime + delayedTime) % 24; // 計算延遲後的實際到達時間，超過24小時則循環回0

            // 3. 輸出
            Console.WriteLine("最終時間是：" + result); //輸出火車到達時間result
        }
    }
}

