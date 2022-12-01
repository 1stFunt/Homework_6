// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double b1 = Read("введите значение b1: ");
double k1 = Read("введите значение k1: ");
double b2 = Read("введите значение b2: ");
double k2 = Read("введите значение k2: ");
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Две прямые пересекутся в X: {x}, Y: {y}");
}
double Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}