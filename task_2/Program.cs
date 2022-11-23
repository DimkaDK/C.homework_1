Console.Write ("Введите первое число: ");

int fistNumber = int.Parse(Console.ReadLine());

Console.Write ("Введите второе число: ");

int secondNumber = int.Parse(Console.ReadLine());

if (fistNumber == secondNumber) 
{
    Console.WriteLine ($" {fistNumber} равно {secondNumber}");
    return;
}

if (fistNumber > secondNumber)
{
    Console.WriteLine ($" {fistNumber} больше {secondNumber}");
}
else
{
    Console.WriteLine ($" {secondNumber} больше {fistNumber}");
}