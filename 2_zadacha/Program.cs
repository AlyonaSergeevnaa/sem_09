// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());


int akkermanfunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return akkermanfunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return akkermanfunction(numberM - 1, akkermanfunction(numberM, numberN - 1));
return akkermanfunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {akkermanfunction(numberM, numberN)}");// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());


int akkermanfunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return akkermanfunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return akkermanfunction(numberM - 1, akkermanfunction(numberM, numberN - 1));
return akkermanfunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {akkermanfunction(numberM, numberN)}");
