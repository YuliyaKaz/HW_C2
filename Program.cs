//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt16(Console.ReadLine());
number = number / 10;
number = number % 10;
Console.WriteLine(number);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number2 >= 999) {
        number2 = number2 / 10;
    }
    number2 = number2 % 10;
    Console.WriteLine(number2);
};

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt16(Console.ReadLine());
if (day == 6 | day == 7){
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}