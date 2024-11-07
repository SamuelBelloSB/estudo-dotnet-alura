using System;

class Conta
{
    public int NumeroIndicador { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public int Senha { get; set; }

    public void ExibirExtrato()
    {
        Console.WriteLine($"Olá {Titular}, o saldo da sua conta é: {Saldo}");
    }

}
