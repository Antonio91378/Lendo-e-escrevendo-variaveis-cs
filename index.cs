using System;

class principal
{
    static void Main()
    {
        int
            v1,
            v2;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("nome digitado: {0}", nome);
        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        Console.WriteLine("A soma dos valores é: {0}", Soma(v1, v2));
    }

    static int Soma(int a, int b)
    {
        int soma;
        return (soma = a + b);
    }
}
