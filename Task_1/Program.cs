//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите целые числа через запятую: ");
string numbers = (Console.ReadLine());
int count = 1;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        count++;
    }
}
int[] newNumbers = new int[count];
int index = 0;
for (int i = 0; i < numbers.Length; i++)
{
    string temp = "";
    while (numbers[i] != ',')
    {
        if (i != numbers.Length - 1)
        {
            temp += numbers[i];
            i++;
        }
        else
        {
            temp += numbers[i];
            break;
        }
    }
    newNumbers[index] = Convert.ToInt32(temp);
    index++;
}
int positive = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (newNumbers[i] > 0) positive++;
}
Console.WriteLine(String.Join(",", newNumbers) + " -> " + positive);