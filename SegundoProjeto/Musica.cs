class Musica 
{
    public Musica(Banda artista) 
    {
        Artista = artista;
    }

    public string Nome {  get; set; }
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => $"A música {Nome} pertence à {Artista}\n";

    public void ExibirFichaTecnica ()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Estado: {(Disponivel ? "Disponível no plano" : "Não disponível")}\n\n") ;
    }


}

