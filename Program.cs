Console.WriteLine("=======Tabuada======");
Console.Write("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuado do número {num}");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}
