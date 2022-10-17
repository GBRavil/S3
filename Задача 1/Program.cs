// //Найти кубы чисел от 1 до N

Console.WriteLine("Введите максимальное число");
int N = Convert.ToInt32(Console.ReadLine());
int s = 3;
double r = 0;
Console.WriteLine("Кубы чисел от 1 до "+N);
for(int i = 1; i<=N; i++) {
    r = Math.Pow(i, s);
    Console.WriteLine(r);
}