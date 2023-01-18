//Задача 25.
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//(Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
Console.WriteLine("Задача №25:");
int A = ReadInt("Введите число: ");
int B = ReadInt("Введите степень: ");
ToDegree(A, B);
//Функция ввода.
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Функция возведения в степень.
void ToDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(A + " в степени " + B + " -> " + result);
}



//Задача 27.
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Задача №27");
int number = Getsum("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
// Функция ввода.
int Getsum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Функция подсчета цифр в числе.
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
// Функция вывода суммы цифр в числе.
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}


//Задача 29. 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
Console.WriteLine("Задача №29");
int lenArray = Array("Введите число: ");
int[] randomArray = new int[lenArray];
// Функция ввода.
int Array(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Функция вывода.
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
