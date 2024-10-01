using Palindrom;

public class Program
{
    public static void Main(string[] args)
    {
        var n = 5;
        var k = 6;

        try
        {
            var count = Logic.CountGoodNumbers(n, k);
            Console.WriteLine($"Количество хороших чисел с {n} цифрами и k = {k}: {count}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}