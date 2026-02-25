using System;

class Pessoa
{
    public string Nome;
}

class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Maria";

        Pessoa pessoa2 = pessoa1;

        pessoa2.Nome = "João";

        Console.WriteLine("Nome da primeira pessoa: " + pessoa1.Nome);
        Console.WriteLine("Nome da segunda pessoa: " + pessoa2.Nome);

    }
}
