 /* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


Console.WriteLine ("Введите первое число: ");
string firstNumber = Console.ReadLine();

Console.WriteLine ("Введите второе число: ");
string secondNumber = Console.ReadLine();

Console.WriteLine ("Введите третье число: ");
string thirdNumber = Console.ReadLine();

int numA = int.Parse(firstNumber);
int numB = int.Parse(secondNumber);
int numC = int.Parse(thirdNumber);

if (numA > numB & numA > numB)
    Console.WriteLine($"Максимальное число: {numA}");

else 
    if (numB > numA & numB > numC)
        Console.WriteLine($"Максимальное число: {numB}");
    else 
    Console.WriteLine($"Максимальное число: {numC}");

    