// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {GetSumDigits(num)}");
int GetSumDigits(int num1)
{
int sum =0;
while (num1 >0)
{
sum= sum+ num1%10;
num1 = num1/10;
}
return sum;
}