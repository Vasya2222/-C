// Задача: Вывести сумму двух чисел двумя способомами

// 1 способ

// Объявляем две переменные при помощи целочисленного типа данных int 
//и присовим переменным занчения

int number = 10;
int number1 = 10;

// Выводим сумму двух чисел

Console.Write("Сумма двух числе - ");
Console.WriteLine(number + number1);

// 2 cпособ

// Объявляем две переменные при помощи целочисленного типа данных int
// и присвоим переменным значения при помощи Console.ReadLine

int num = int.Parse(Console.ReadLine());
int num1 = int.Parse(Console.ReadLine());

// Выводим сумму двух чисел введенного пользователем

Console.Write("Сумма двух чисел равна - ");
Console.WriteLine(num + num1);