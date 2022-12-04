/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int x = 0;

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
while (num > 99)
{
    if (num > 99 && num < 1000)
    {
        x = num % 10;
        Console.WriteLine(x);
    }
    num = num / 10;
}
