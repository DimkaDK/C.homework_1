Console.Write ("Введите число (число должно быть больше 1): ");

int Number = int.Parse(Console.ReadLine());

if (Number <= 1)
{
    Console.WriteLine ("Число задано неверно");
    return;
}

int index = 1;

while (index <= Number)
{
    if (index%2 == 0)
    {
        Console.Write ($"{index}, ");       
    }
     index++;
}