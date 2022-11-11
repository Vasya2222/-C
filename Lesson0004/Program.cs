
// Задача: Поприветсвовать пользователя и вывести сумму, произведение, деление,
// вычитание, деление с остатком введенным пользователем

// Приветствуем пользователя
Console.Write("Введите ваше имя -> ");
string name = Console.ReadLine();
Console.Write("Привет, ");
Console.WriteLine(name + "!");

// Вести  числа
Console.WriteLine("Введите числа");

Console.Write("Введите первое число -> ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число -> ");
int number1 = int.Parse(Console.ReadLine());


// Вывести сумму чисел

Console.Write("Сумма чисел равна -> ");
Console.WriteLine(number + number1);

// Ввывести вычитание чисел

Console.Write("Вычитание чисел равна -> ");
Console.WriteLine(number - number1);