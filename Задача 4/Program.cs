//Показать кубы чисел, заканчивающихся на четную цифру

class CubeNumbers {
  static void Main() {
    double [] num = {22,35,14,11,52};  
    int stepen = 3;
    for (int i = 0; i < num.Length; i++) {
        if((num[i]%10)%2==0) {
            num[i] = Math.Pow(num[i], stepen);
            Console.WriteLine(num[i]);
        } 
    }
  }
}