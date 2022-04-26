using App2020;

Contas contas = new Contas();

contas.Soma = int.Parse(Console.ReadLine());
contas.Subtracao = int.Parse(Console.ReadLine());
contas.Mutiplicacao = double.Parse(Console.ReadLine());
contas.Divicao = double.Parse(Console.ReadLine());

Console.WriteLine($"Soma : {contas.Somar()}");
Console.WriteLine($"Subtração : {contas.Subitrair()}");
Console.WriteLine($"Mutiplicação : {contas.Multiplicar()}");
Console.WriteLine($"Divição : {contas.Dividir()}");