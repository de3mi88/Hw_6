//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел происходит через Enter, останавливается при введении слова "stop"

Console.Write("Вам потребуется ввести числа, а я выведу количество положительных. Введите количество чисел которые будете использовать: ");
bool Array = int.TryParse(Console.ReadLine(), out int number);

if (!Array)
{
    Console.WriteLine("Не верные данные ввода, попробуйте ввести другие числа");
}

int GetNumber(int x)
{
    int[] array = new int[x];
    Console.WriteLine("Введите числа: ");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }

    int num = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            num = num + 1;
        }
    }
    return num;
}
int positive = GetNumber(number);
Console.WriteLine($"Количество положительных чисел = {positive}");
