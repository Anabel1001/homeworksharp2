// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int result = new Random().Next(100, 1000);
System.Console.WriteLine(result);
int secondnum = (result/10) % 10;
System.Console.WriteLine($"{secondnum}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100<=0)
{
    Console.WriteLine("Такой цифры нет.");
}
else
{
    while ( number/1000 > 0 )
    {
        number /= 10;
    }
    Console.WriteLine(number%10);
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1) {
    System.Console.WriteLine("Понедельник, не выходной день");
}
else if (day == 2) {
    System.Console.WriteLine("Вторник, не выходной день");
}
else if (day == 3) {
    System.Console.WriteLine("Среда, не выходной день");
}
else if (day == 4) {
    System.Console.WriteLine("Четверг, не выходной день");
}
else if (day == 5) {
    System.Console.WriteLine("Пятница, не выходной день");
}
else if (day == 6) {
    System.Console.WriteLine("Суббота, выходной день");
}
else if (day == 7) {
    System.Console.WriteLine("Воскресенье, выходной день");
}
else
{
System.Console.WriteLine("Такого дня не существует");
}
