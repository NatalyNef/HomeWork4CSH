/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
Step(numberA, numberB);

void Step(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{numberA}, {numberB} -> {result}");
}

int ReadInt(string Step)
{
    Console.Write(Step);
    return Convert.ToInt32(Console.ReadLine());
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadInt("Введите число: ");
int sum = NumberLen(number);
SumNumbers(number, sum);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($" -> {sum}");
}



//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int IntArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[IntArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/