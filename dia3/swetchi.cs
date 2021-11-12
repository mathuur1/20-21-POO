class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um valor inteiro entre 1 e 12");
    int x = int.Parse(Console.ReadLine());
    switch (x) {
      case 1: Console.WriteLine("Janeiro"); break;
      case 2: Console.WriteLine("Fevereiro"); break;
      case 12:Console.WriteLine("Dezembro"); break;
      default:Console.WriteLine("Mês inválido"); break;
    }
  }
}