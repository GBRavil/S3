//Написать программу вычисления произведения чисел от 1 до N

class SumNumbers {
  static void Main() {
    int [] num = {3,5,4,1,2};  
    int sum = 0;
    for (int i = 0; i < num.Length; i++) {
        sum = sum + num[i];
    }
    Console.WriteLine(sum);
  }
}