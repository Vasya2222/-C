// задача: имеется одномерный массив array из n элементов. требуется 
// найти элемент массива, равный find

Console.WriteLine("Код для проверки числа в массиве");

Console.Write("Введите число для нахождения числа в массиве -> ");
int find = Convert.ToInt32(Console.ReadLine());

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int index = 0;

while (index < 9){
    if (array[index] == find){
        Console.WriteLine("Да число есть!");
        break;
    }
    index++;
}
