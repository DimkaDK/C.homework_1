Console.Write ("Введите первое число: ");

int Number1 = int.Parse(Console.ReadLine());

Console.Write ("Введите второе число: ");

int Number2 = int.Parse(Console.ReadLine());

Console.Write ("Введите третье число: ");

int Number3 = int.Parse(Console.ReadLine());

int max = Number1;

if (max < Number2)
{
    max = Number2;
}
if (max < Number3)
{
    max = Number3;
}

Console.WriteLine ($" Число {max} наибольшее из этих трех чисел");