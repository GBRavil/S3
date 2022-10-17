//Подсчитать сумму цифр в числе

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(num>0) {
    sum = sum + num%10;
    num = num/10;
}
Console.WriteLine(sum);

// Второй вариант решения:
// Console.WriteLine("Введите число");
// String s = Console.ReadLine();
// int sum = 0;
// int ss = s.Length;
// for(int i = 0; i<ss; i++) {
//     sum = sum + (Convert.ToInt32(s[i]))-48;
// }
// Console.WriteLine(sum);
// Не понимаю почему при втором варианте решения задачи выдает линие 48 единиц, если объясните буду признателен.
