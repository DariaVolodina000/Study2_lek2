// Нахождения максимума из 9 чисел


int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}


int a1 = 3;
int a2 = 622;
int a3 = 3;
int b1 = 43;
int b2 = 66;
int b3 = 3443;
int c1 = 31;
int c2 = 69;
int c3 = 35;

int max = Max(Max(a1,a2,a3), Max(b1,b2,b3),Max(c1,c2,c3));
// int max1= Max(a1,a2,a3);
// int max2= Max(b1,b2,b3);
// int max3= Max(c1,c2,c3);
Console.WriteLine(max);
