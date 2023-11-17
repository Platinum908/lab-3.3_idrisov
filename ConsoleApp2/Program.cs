//3.3 Высокий уровень #2

try{
    Console.Write(" Введите x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write(" Введите n: ");
    int n = int.Parse(Console.ReadLine());
    double S = 0;
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0){
            S += Math.Cos(i * x) / i; }
        else{
            S += Math.Cos(i * x) / i; }
    }
    Console.WriteLine($"S={S:F2}");
}
catch (Exception err){
    Console.WriteLine(err); }