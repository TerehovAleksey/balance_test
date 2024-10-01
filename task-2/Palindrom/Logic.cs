namespace Palindrom;

public static class Logic
{
    /// <summary>
    /// Функция для проверки, является ли число палиндромом
    /// (одинаково читается в обоих направлениях)
    /// </summary>
    public static bool IsPalindrome(long x)
    {
        var original = x.ToString();
        var reversedArray = original.ToCharArray();
        Array.Reverse(reversedArray);
        var reversed = new string(reversedArray);
        return original == reversed;
    }

    /// <summary>
    /// Функция для проверки, является ли число k-палиндромическим
    /// (является палиндромом и делится на k)
    /// </summary>
    public static bool IsKPalindrome(long x, int k)
    {
        return IsPalindrome(x) && x % k == 0;
    }

    /// <summary>
    /// Рекурсивная функция для генерации всех перестановок строки
    /// </summary>
    public static void GetPermutationsRecurcive(string s, HashSet<string> result, string prefix = "")
    {
        if (s.Length == 0)
        {
            result.Add(prefix);
        }
        else
        {
            for (var i = 0; i < s.Length; i++)
            {
                var rem = string.Concat(s.AsSpan(0, i), s.AsSpan(i + 1));
                GetPermutationsRecurcive(rem, result, prefix + s[i]);
            }
        }
    }

    /// <summary>
    /// Функция для генерации всех перестановок строки
    /// </summary>
    public static IEnumerable<long> GetPermutations(int number)
    {
        var permutations = new HashSet<string>();
        GetPermutationsRecurcive(number.ToString(), permutations);
        return permutations
            .Where(p => p[0] != '0')
            .Select(long.Parse);
    }

    /// <summary>
    /// Функция для проверки, является ли число хорошим
    /// </summary>
    public static bool IsGoodNumber(int x, int k)
    {
        var permutations = GetPermutations(x);
        foreach (var perm in permutations)
        {
            if (IsKPalindrome(perm, k))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Функция для подсчета количества хороших чисел с n цифрами
    /// </summary>
    public static int CountGoodNumbers(int n, int k)
    {
        if (n < 1 || n > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "Число должно быть от 1 до 10");
        }

        if (k < 1 || k > 9)
        {
            throw new ArgumentOutOfRangeException(nameof(k), "Число должно быть от 1 до 10");
        }

        var count = 0;
        var start = (int)Math.Pow(10, n - 1);
        var end = (long)Math.Pow(10, n) - 1;

        for (var i = start; i <= end; i++)
        {
            if (IsGoodNumber(i, k))
            {
                count++;
            }
        }

        return count;
    }
}