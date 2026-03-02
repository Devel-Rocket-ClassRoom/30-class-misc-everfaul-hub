using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== 기본 쿼리 ===");
        var query1 = new QueryBuilder()
                        .Select("*")
                        .From("Users")
                        .Build();
        Console.WriteLine(query1);

        Console.WriteLine("\n=== 조건 쿼리 ===");
        var query2 = new QueryBuilder()
                        .Select("Name, Age")
                        .From("Users")
                        .Where("Age > 18")
                        .Build();
        Console.WriteLine(query2);

        Console.WriteLine("\n=== 정렬 쿼리 ===");
        var query3 = new QueryBuilder()
                        .Select("*")
                        .From("Products")
                        .Where("Price > 1000")
                        .OrderBy("Price")
                        .Build();
        Console.WriteLine(query3);
    }
}