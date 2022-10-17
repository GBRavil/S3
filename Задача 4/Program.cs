//Показать кубы чисел, заканчивающихся на четную цифру

// class CubeNumbers {
//   static void Main() {
//     double [] num = {22,35,14,11,52};  
//     int stepen = 3;
//     for (int i = 0; i < num.Length; i++) {
//         if((num[i]%10)%2==0) {
//             num[i] = Math.Pow(num[i], stepen);
//             Console.WriteLine(num[i]);
//         } 
//     }
//   }
// }
Console.WriteLine("Введите максимальное число не меньше 10");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру от 10 до "+N);
int s = 3;
double num = 0;
for (int i = 10; i <=N; i++) {
    if((i%10)%2==0) {
        num = Math.Pow(i, s);
        Console.WriteLine(num);
    }
}