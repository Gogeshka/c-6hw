/*Task 1

Console.Write("Введите числа: ");
int[] num = StTo(Console.ReadLine());
PArray(num);
int count= 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        count++;
    }
}
int[] StTo(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] num = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;
}
void PArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
Console.WriteLine();
Console.WriteLine($"Значений больше 0 = {count}");
*/

/*Task 2

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (b1 == b2 & k1 == k2)
{
    Console.WriteLine("Две прямые лежат друг на друге! Введите другие значения");
}
else 
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты пересечения прямых - X: {x}, Y: {y}");
}
*/