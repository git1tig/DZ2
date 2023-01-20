
// Чекаем день недели

Boolean DayCheck(int Day)
{
    if (Day == 6 || Day==7) 
        return true;
    else return false;
}

int DayOfWeek, i;
Console.Write("Введите день недели от 1 до 7: ");
while (!Int32.TryParse(Console.ReadLine(), out DayOfWeek) || DayOfWeek < 1 || DayOfWeek > 7)
    {
    Console.WriteLine("Ввод " + DayOfWeek + " неверный. Пожалуйста, введите корректное число");
    }

if (DayCheck(DayOfWeek))
    Console.WriteLine(DayOfWeek + " - это выходной, отдыхаем!");
else 
    Console.WriteLine(DayOfWeek + " - это не выходной, пашем!");
