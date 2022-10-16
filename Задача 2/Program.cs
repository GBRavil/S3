//Подсчитать сумму цифр в числе

class SumNumbers {
  static void Main() {
    Console.WriteLine("Введите число");
    string num = Console.ReadLine();
    SumNumbers x = new SumNumbers();   
    x.Sumnum(num);
  }
  void Sumnum (string sn) {
    int n = Convert.ToInt32(sn);
    int sum = 0;
    while(n>0) {
        sum = sum + n%10;
        n = n/10;
    }
    Console.WriteLine(sum);  
  }
}