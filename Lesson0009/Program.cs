int Max(int arg1, int arg2, int arg3){
    int result =arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}
int num1 = 12;
int num2 = 1;
int num3 = 20;
int num4 = 100;
int num5 = 54;
int num6 = 60;
int num7 = 80;
int num8 = 8888;
int num9 = 8822;

int max = Max(Max(num1, num2, num3), Max(num4, num5, num6), Max(num7, num8, num9));


Console.Write("Максимальное число равно -> ");
Console.WriteLine(max);