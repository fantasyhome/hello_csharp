namespace hello_c_sharp;

using System;
using System.Diagnostics;
using System.Threading.Tasks;

public static class AsyncDemo
{
   static async void Show()
   {
      Console.WriteLine("2");
      
      await Task.Delay(3000);
      
      Console.WriteLine("3");
   }

   public static void Run()
   {
      Console.WriteLine("1");
      
      Show();
      
      Console.WriteLine("4");

      Console.ReadLine();
   }
   
   // 模拟下单：同步执行
   static void OrderDelivery()
   {
      Console.WriteLine("Ordered food.");
   }

   // 模拟等待外卖：异步等待 3 秒
   static async Task WaitForDelivery()
   {
      Console.WriteLine("Waiting for delivery...");

      await Task.Delay(3000);

      Console.WriteLine("Food has arrived!");
   }

   // 模拟学习 C#：异步等待 10 秒
   static async Task LearnCSharp()
   {
      Console.WriteLine("Started learning C#...");

      await Task.Delay(5000);

      Console.WriteLine("Finished learning C#.");
   }

   // 模拟吃饭：异步等待 2 秒
   static async Task Eat()
   {
      Console.WriteLine("Started eating...");

      await Task.Delay(2000);

      Console.WriteLine("Finished eating.");
   }

   public static async Task Run2()
   {
      var sw = Stopwatch.StartNew();

      OrderDelivery();

      // 同时启动等待外卖和学习任务
      var waitingTask = WaitForDelivery();
      var learningTask = LearnCSharp();

      // 外卖送达前，等待外卖任务完成
      await waitingTask;

      // 外卖送到后吃饭
      await Eat();

      // 吃完饭后，等待学习任务完成
      await learningTask;

      sw.Stop();

      Console.WriteLine(
         $"Total time: {sw.Elapsed.TotalSeconds:F2} seconds");
   }
}