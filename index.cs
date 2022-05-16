using System;

class principal
{
    static void Main()
    {
        int
            v1,
            v2,
            soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("nome digitado: {0}", nome);
        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma dos valores é: {0}", soma);
    }
}
