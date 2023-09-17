//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int numN = int.Parse(Console.ReadLine()??"0");
int i = 2;
while(i < numN)
{
    Console.Write(i +", ");
    i = i + 2;
}
Console.WriteLine(numN % 2 == 0 ? numN : "");

// Console.WriteLine(numN % 2 == 0 ? "Число чётное" : "Число нечётное");

// int evNumN = (-1) * numN;
// while(evNumN < numN)
// {
//     Console.Write(evNumN + " ,");
//     evNumN = evNumN + 1;
// }
// Console.WriteLine (numN);