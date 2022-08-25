/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/

Console.Write("Введите натуральное число N,\nчтобы вывести все натуральные числа от N до 5: ");
string n = Console.ReadLine();

var count = ExceptionHandling(n);



if (count.exception && count.number >= 0)
{

    Numbers(count.number);
  
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{n} -> Некорректный ввод!");

   
}

void Numbers(int last)
{
    if (last == 0)
    {
        return;
    }
    Console.Write($"{last} ");
    Numbers(last - 1);
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
}
