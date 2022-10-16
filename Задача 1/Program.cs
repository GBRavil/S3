// //Найти кубы чисел от 1 до N
class Cube {
  static void Main() {
    double [] numbers = {1,5,3,4,2};
    int stepen = 3;
    Cube x = new Cube();
    x.NewCube(numbers, stepen);
  }
    
  void NewCube(double [] n, int s) {
    for(int i = 0; i < n.Length; i++) {
        n[i] = Math.Pow(n[i], s);
        Console.WriteLine(n[i]);
    }
  } 
}