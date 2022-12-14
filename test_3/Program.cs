/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void TableOfCubes(int[] amount)
{
    int i = amount.Length;
    int index = 0;
    while (index < i)
    {
        Console.Write(amount[index] + " ");
        index++;
    }
}

void Cube(int[] cube)
{
    int i = 0;
    int length = cube.Length;
    while (i < length)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
        i++;
    }
}

int[] arry = new int[cube + 1];

Cube(arry);

TableOfCubes(arry);

