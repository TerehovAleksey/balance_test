# Тестовое задание

## Задание 1

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры в compile-time.

## Задание 2

Вам даны два положительных целых числа n и k.
Целое число x называется k-палиндромическим, если:

- x является палиндромом.
- x делится на k.

Число называется хорошим, если его цифры можно переставить так, чтобы получилось k-палиндромическое число. Например, для k = 2 число 2020 можно переставить в k-палиндромическое число 2002, в то время как 1010 нельзя переставить в k-палиндромическое число, для k = 2.
Верните количество хороших чисел, содержащих n цифр.
Обратите внимание, что у числа не должно быть ведущих нулей, ни до, ни после перестановки. Например, 1010 нельзя переставить в 101.

### Пример 1

Input: n = 3, k = 5

Output: 27

> Объяснение:
Некоторые числа удовлетворяющие условию
551 потому что перестановкой цифр можно получить число 515, которая является палиндромом и делится на k.
525 потому что само является палиндромом и делится на k.

### Пример 2

Input: n = 1, k = 4

Output: 2
> Объяснение:
Два хороших числа это  4 и 8.

### Пример 3

Input: n = 5, k = 6

Output: 2468

### Пример 4

Input: n = 10, k = 1

Output: 41457024

>Ограничения:
1 <= n <= 10
1 <= k <= 9

>Ограничения по времени : 1 секунда.
