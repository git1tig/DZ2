// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
double num1 = 0;
int Pos = 0;
int n = 6;


// ***************************Метод выдаёт цифру на определённой позиции в числе**********************
// выдает -1 если в этой позиции ничего нет

int PosInNum(double number, int position)
{
    double i = 6; //определяет количество разрядов числа!
    int CurrentPosition = 0;
    int CurrentPosNumber = 0;
    i = i - 1; // делить начнём с 10 в степени i-1

    if (number < 10)
    {
        CurrentPosNumber = Convert.ToInt32(number);
        if (position > 1) CurrentPosNumber = -1; // если изначально ввели однозначное число, а разряд хотят получить отличный от 1
        return CurrentPosNumber;
    }

    while (i > 0)
    {

        if (number / Math.Pow(10, i) > 1)
        {
            Console.WriteLine("number / Math.Pow(10, i) > 1 !!!");
            Console.WriteLine("Число: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber + " n/10powI  " + Convert.ToInt32(Math.Truncate(number % Math.Pow(10, i))) + " число на этой позиции: " + CurrentPosNumber);

            CurrentPosition++;
            Console.WriteLine("CurrentPosition++;" + CurrentPosition);
            Console.WriteLine("now position  is " + CurrentPosition);
            CurrentPosNumber = Convert.ToInt32(Math.Truncate(number / Math.Pow(10, i)));
            Console.WriteLine("currentPosNumber is " + CurrentPosNumber);

            if (CurrentPosition == position)
            {
                Console.WriteLine("Приехал к нужной позиции!");
                Console.WriteLine("Число: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber + " n/10powI  " + Convert.ToInt32(Math.Truncate(number % Math.Pow(10, i))) + " число на этой позиции: " + CurrentPosNumber);
                return CurrentPosNumber;
            }

            number = number % Math.Pow(10, i);
        }
        i = i - 1;
        Console.WriteLine("Уходим на след круг цикла   Число: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber + " n/10powI  " + Convert.ToInt32(Math.Truncate(number % Math.Pow(10, i))) + " число на этой позиции: " + CurrentPosNumber);
        if (i == 0)
        {
             CurrentPosition++;
            // Console.WriteLine("CurrentPosition++;" + CurrentPosition);
            // Console.WriteLine("now position  is " + CurrentPosition);
            CurrentPosNumber = number;

            if (CurrentPosition<position)
            {
                CurrentPosNumber=-1;
                Console.WriteLine("CurrentPosition<position");
                return CurrentPosNumber;
                

            } 
            CurrentPosNumber = Convert.ToInt32(number);
            return CurrentPosNumber;
            Console.WriteLine("i=0!");
        }

    }
    Console.WriteLine("перед  выходом: " + number + " i= " + i + "  position =  " + CurrentPosition + " цифра: " + CurrentPosNumber);
    return CurrentPosNumber;

}

// *****************************************Основная программа***********************************************************


while (num1 <= 0 || num1 > 1000000) //ПРОВЕРКА КОРРЕКТНОСТИ ВВОДА
{
    Console.Write("Введите число от 1 до " + (Math.Pow(10, n) - 1) + ": ");
    num1 = Double.Parse(Console.ReadLine());
    if (num1 <= 0 || num1 > (Math.Pow(10, n) - 1)) Console.WriteLine("Неверное число!");
}
Console.WriteLine();

while (Pos <= 0 || Pos > n) //ПРОВЕРКА КОРРЕКТНОСТИ ВВОДА
{
    Console.Write("Введите позицию в числе для вывода от 1 до " + n + ": ");
    Pos = int.Parse(Console.ReadLine());
    if (Pos <= 0 || Pos > n) Console.WriteLine("Неверное число!");
}


if (PosInNum(num1, Pos) > 0)
    Console.WriteLine("На позиции " + Pos + " в числе " + num1 + " стоит цифра " + PosInNum(num1, Pos));
else
    Console.WriteLine("На позиции " + Pos + " в числе " + num1 + " ничего нет");