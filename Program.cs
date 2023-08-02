// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

// void getNaturalNumbers(int number)
// {
//     if (number < 1)
//     {
//         return;
//     }
//    Console.Write(number + " "); 
//    getNaturalNumbers(--number);
   
// }
// getNaturalNumbers(number);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int sumNaturalElements(int number1, int number2)
// {
//     if (number1 >= number2)
//     {
//         return number1;
//     }
//     return (number1 + sumNaturalElements(++number1, number2));
// }

// Console.WriteLine(sumNaturalElements(number1, number2));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n");
// int n = Convert.ToInt32(Console.ReadLine());


// int ackkerman(int m, int n){
//     if (m == 0){
//         return n + 1;
//     }
//     else if (n == 0){
//         return ackkerman(m - 1, 1);
//     }
//     else{
//         return ackkerman(m - 1, ackkerman (m, n - 1));
//     }
// }

// Console.WriteLine(ackkerman(m, n));
