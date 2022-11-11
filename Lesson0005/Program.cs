
// Задача: Поприветсвовать пользователя и вывести сумму, произведение, деление,
// вычитание, деление с остатком рандомными числами

// Приветствуем пользователя
Console.Write("Введите ваше имя -> ");
string name = Console.ReadLine();
Console.Write("Привет, ");
Console.WriteLine(name + "!");

// Вести  числа
Console.WriteLine("Введите диапазон");

Console.Write("Введите первое число диапазона -> ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число диапазона -> ");
int number1 = int.Parse(Console.ReadLine());

// рандомное число

int num = new Random().Next(number, number1);
int num1 = new Random().Next(number, number1);

// Ввывести рандомные числа
Console.Write("Первое случайное число ->");
Console.WriteLine(num);

Console.Write("Вотрое случайное число -> ");
Console.WriteLine(num1);
// Вывести сумму чисел

Console.Write("Сумма чисел равна -> ");
Console.WriteLine(num + num1);

// Ввывести вычитание чисел

Console.Write("Вычитание чисел равна -> ");
Console.WriteLine(num - num1);

// Ввывести произведение чисел

Console.Write("Произведение чисел равна -> ");
Console.WriteLine(num * num1);

// Ввывести деление чисел

Console.Write("Деление чисел равна -> ");
Console.WriteLine(num / num1);

// Ввывести деление по модулю чисел

Console.Write("Деление по модулю равна -> ");
Console.WriteLine(num % num1);
