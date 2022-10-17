//Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите максимальное число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Произведения чисел от 1 до "+N);
int s = 1;
for (int i = 1; i<=N; i++) {
    s = s * i;
    Console.WriteLine(s);
}