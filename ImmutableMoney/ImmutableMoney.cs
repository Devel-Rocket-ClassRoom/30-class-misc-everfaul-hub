using System;
using System.Runtime.InteropServices;

class Program
{
    public static void Main()
    {
        Console.WriteLine("=== 초기 화페 ===");
        Money wallet = new Money(100, 50);
        Console.WriteLine($" 지갑: {wallet}");
        Console.WriteLine();
        Console.WriteLine("=== 화폐 추가 ===");
        Money addwallet = wallet.Add(50, 30);
        Console.WriteLine($" 추가 후: {addwallet}");
        Console.WriteLine($" 원본지갑: {wallet}");
        Console.WriteLine();
        Console.WriteLine("=== 화페 차감 ===");
        Money subtractwallet = wallet.Subtract(70, 60);
        Console.WriteLine($" 차감 후: {subtractwallet}");
        Console.WriteLine($" 원본 지갑: {wallet}");
        Console.WriteLine();
        Money chainedResult = wallet.Add(50, 0).Subtract(30, 20);
        Console.WriteLine("=== 메서드 체이닝 ===");
        Console.WriteLine($"결과: {chainedResult}");
    }
}