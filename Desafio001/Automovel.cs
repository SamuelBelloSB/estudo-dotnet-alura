class Automovel
{
    private int _ano;


    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano 
    {
        get { return _ano; }
        set 
        {
            _ano = (value < 1960 || value > 2024) ? value : throw new ArgumentOutOfRangeException("Ano deve estar entre 1960 e 2024.");
        }
    }
    public int PlacaDeIdentificacao { get; set; }
    public double Peso { get; set; }
    public double Preco { get; set; }

    public string DescricaoDetalhada => $"O modelo {Modelo} da {Marca} lançado em {Ano} custa {Preco}.";

    public void Acelerar()
    {
        Console.WriteLine($"O automovel acelerou!");
    }
    public void Frear()
    {
        Console.WriteLine($"O automovel freiou!");
    }
    public void Buzinar()
    {
        Console.WriteLine($"Biiiiiiiiiii!!!");
    }
}