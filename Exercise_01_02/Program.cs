/* Задача 1: Собрать строку с числами от a до b, a <= b */

// string NumbersRec(int a, int b)
// {
//     if(a <= b)
//     {
//         return ($"{a} " + NumbersRec(a + 1, b));
//     }
//     else
//     {
//         return String.Empty;
//     }
// }
// Console.WriteLine(NumbersRec(1, 10));

/* Задача 2: Сумма чисел от 1 до n */

int SumRec(int n)
{
    if(n == 1)
    {
        return 1;
    }
    else 
    {
        return(n + SumRec(n - 1));
    }
}
Console.WriteLine(SumRec(10));