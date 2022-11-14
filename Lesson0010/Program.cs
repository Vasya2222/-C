// усовершенствовать код по нахождению максимального числа среди 9 чисел при помощи массива и функций

int Max(int a, int b, int c){
    int result = a;
    if (result < b) result = b;
    if (result < c) result = c;

    return result;
}

int[] array = {22, 55, 55,78, 22, 1, 599, 8, 3135, 68};

int max = Max(Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8]));

Console.WriteLine(max);