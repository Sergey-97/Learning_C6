/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine()!);
PrintArray(numbers);
Console.ResetColor ();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write($"Количество чисел больше 0 = ");
Console.ResetColor ();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($" {sum} ");
Console.ResetColor ();

int[] StringToNum(string natural)
{
    int count = 1;
    for (int i = 0; i < natural.Length; i++)
    {
        if (natural[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < natural.Length; i++)
    {
        string temp = "";

        while (natural [i] != ',')
        {
        if(i != natural.Length - 1)
        {
            temp += natural [i].ToString();
            i++;
        }
        else
        {
            temp += natural [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}