// Задача: Поприветсвовать пользователя запросив имя и усовершенствовать арифметические операторы(калькулятор)

// запросить имя пользователя
Console.Write("Введите Ваше имя -> ");
string? name = Console.ReadLine();
// поприветствовать пользователя

Console.Write("Привет, ");
Console.WriteLine(name);

// Ввод чисел

// Запрос пользователю ввести числа

Console.Write("Введите 1 число -> ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());


// запрос пользователю ввести оператор +, -, *, /, %

Console.Write("Введите оператор +, -, *, /, %");
string? op = Console.ReadLine();

// Проверка условий

// if (op == '+'){
//     Console.Write("Сумма чисел равна -> ");
//     Console.WriteLine(num + num1);
// }

// else if(op == '-'){
//     Console.Write("Вычитание чисел равна -> ");
//     Console.WriteLine(num - num1);
// }

// else if(op == '*'){
//     Console.Write("Произведение чисел равна -> ");
//     Console.WriteLine(num * num1);
// }

// else if(op == '/'){
//     Console.Write("Деление чисел равна -> ");
//     Console.WriteLine(num / num1);
// }

// else if(op == '%'){
//     Console.Write("Деление по модулю чисел равна -> ");
//     Console.WriteLine(num % num1);
// }

// else{
//     Console.WriteLine("Вы ввели не тот оператор");
// }