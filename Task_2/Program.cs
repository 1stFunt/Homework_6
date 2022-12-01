// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int b1 = ReadInt("введите значение b1: ");
int k1 = ReadInt("введите значение k1: ");
int b2 = ReadInt("введите значение b2: ");
int k2 = ReadInt("введите значение k2: ");
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    Console.WriteLine($"Две прямые пересекутся в X: {x}, Y: {y}");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}