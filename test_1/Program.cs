/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void CheckingFiveDigitNumber(string fiveDigitNumber)

{
    if (fiveDigitNumber[0] == fiveDigitNumber[4] || fiveDigitNumber[1] == fiveDigitNumber[3])
    {
        Console.WriteLine($"Введенное Вами число: {fiveDigitNumber} - является палиндромом.");
    }
    else Console.WriteLine($"Введенное Вами число: {fiveDigitNumber} - НЕ является палиндромом.");
}

Console.WriteLine("Введите пятизначное число: ");

int fiveDigitNumber;

while (!int.TryParse(Console.ReadLine(), out fiveDigitNumber) || fiveDigitNumber > 99999 || fiveDigitNumber < 9999)
{
    Console.WriteLine("Ошибка! Введите ПЯТИЗНАЧНОЕ число: ");
}

string fiveDigitNumberString = fiveDigitNumber.ToString();
CheckingFiveDigitNumber(fiveDigitNumberString);


