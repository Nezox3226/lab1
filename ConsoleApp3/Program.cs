const double focharik = 0.123;
const double foshkal = 0.06;
void one()
{
    Console.WriteLine("Hello, World!");
    string name = Console.ReadLine();
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Привет , {name}. вам через год будет {++age}");
}
double tocharik(double charik)
{
    return charik * focharik;
}
double toshkalik(double skalik)
{
    return skalik * foshkal;
}
double maximus(double a, double b, double c)
{
    double aa = a; double bb = b; double cc = c;
    if (a > b && a > c) { 
        return aa;
    }
    else if (a < b && b > c)
    {
        return bb;
    }
    else if (c > a && c > b)
    {
        return cc;
    }
    else
    {
        return aa;
    }

}


void two()
{
    Console.WriteLine("введите имена персонажей ");
    string per1 = Console.ReadLine();
    string per2 = Console.ReadLine();
    string per3 = Console.ReadLine();
    Console.WriteLine("сколько чарок выпил первый ");
    int charik1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("сколько шкаликов выпил второй ");
    int shkal1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("сколько чарок и шкаликов выпил третий ");
    int charik2 = Convert.ToInt32(Console.ReadLine());
    int shkal2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сколько выпил первый персонаж (В литрах)");
    Console.WriteLine(tocharik(charik1));
    Console.WriteLine("Сколько выпил второй персонаж ( В литрах)");
    Console.WriteLine(toshkalik(shkal1));
    Console.WriteLine("Сколько выпил третий персонаж (В литрах)");
    Console.WriteLine(toshkalik(shkal2) + tocharik(charik2));
    if (tocharik(charik1) < 1 && tocharik(charik1) > 0.5)
    {


        Console.WriteLine($" ОН ВОДОХЛЕП {per1}");
    }
    else if (toshkalik(shkal1) < 1 && toshkalik(shkal1) > 0.5)
    {
        Console.WriteLine($" ОН ВОДОХЛЕП {per2}");
    }
    else if (tocharik(charik2) + toshkalik(shkal2) > 0.5 && tocharik(charik2) + toshkalik(shkal2) < 1)
    {
        Console.WriteLine($" ОН ВОДОХЛЕП {per3}");
    }
    Console.WriteLine($"Всего выпито = {(toshkalik(shkal2) + tocharik(charik2)) + (toshkalik(shkal1)) + (tocharik(charik1))}");
    Console.WriteLine($"Максиальный обьем = {maximus((toshkalik(shkal2) + tocharik(charik2)) , (toshkalik(shkal1)), (tocharik(charik1)))}");
}

void three()
{
    Console.WriteLine("Введите дату своего рождения в формате dd.mm.yyyy:");
    DateTime birthDate = DateTime.Parse(Console.ReadLine());

    DateTime now = DateTime.Now;
    int age = now.Year - birthDate.Year;
    if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
    {
        age--;
    }

    string yearWord;
    if (age % 10 == 1 && age % 100 != 11)
    {
        yearWord = "год";
    }
    else if (age % 10 >= 2 && age % 10 <= 4 && (age % 100 < 10 || age % 100 >= 20))
    {
        yearWord = "года";
    }
    else
    {
        yearWord = "лет";
    }

    Console.WriteLine($"Вам {age} {yearWord}.");

}
 void fife()
{
    Console.Write("Введите целое неотрицательное число n: ");
    int n = int.Parse(Console.ReadLine());

    bool[] isPrime = new bool[n + 1];
    for (int i = 2; i <= n; i++)
    {
        isPrime[i] = true;
    }

    isPrime[0] = false;
    isPrime[1] = false;

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (isPrime[i])
        {
            for (int j = i * i; j <= n; j += i)
            {
                isPrime[j] = false;
            }
        }
    }

    Console.WriteLine("Простые числа в промежутке [2, {0}]:", n);
    for (int i = 2; i <= n; i++)
    {
        if (isPrime[i])
        {
            Console.Write(i + " ");
        }
    }
}
void seven()
{
    Console.Write("Введите массив целых чисел через пробел: ");
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    Console.Write("Введите число, которое нужно удалить из массива: ");
    int numberToRemove = int.Parse(Console.ReadLine());

    int index = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] != numberToRemove)
        {
            numbers[index++] = numbers[i];
        }
    }

    Array.Resize(ref numbers, index);

    Console.WriteLine("Массив без числа {0}: [{1}]", numberToRemove, string.Join(", ", numbers));

}
 void eight()
{
    // Создаем массив и заполняем его случайными числами
    int[] numbers = new int[70];
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100);
    }

    // Сортируем элементы на четных позициях
    for (int i = 0; i < numbers.Length; i += 2)
    {
        int minIndex = i;
        for (int j = i + 2; j < numbers.Length; j += 2)
        {
            if (numbers[j] < numbers[minIndex])
            {
                minIndex = j;
            }
        }
        if (minIndex != i)
        {
            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }
    }

    // Выводим полученный массив на экран
    Console.WriteLine("Отсортированный массив:");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
}
eight();
