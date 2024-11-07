class Album
{
    private List<Musica> musicas = new List<Musica> ();

    public Album ( string name)
    {

    }

    public string Nome { get; set; }
    public int DuracaoDoAlbum => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }
}