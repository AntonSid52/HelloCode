int Max(int arg1, int arg2, int arg3)
{
    int result = arg2;
    if(arg2>result) result = Max;
    if(arg3>result) result = Max;
}
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max =");
Console.WriteLine(max);