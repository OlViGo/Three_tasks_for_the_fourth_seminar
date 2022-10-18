// Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Print an integrated a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Print an integrated b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($" Number a in the degree of b {GetDegree(a)}");
int GetDegree(int a2)
{
int step = a2;
for (int i = 1; i < b; i++)
{
step = step * a2;
}
return step;
}
