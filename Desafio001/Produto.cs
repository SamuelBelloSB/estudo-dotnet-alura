class Produto
{
    private int _estoque;
    private double _preco;

    public int Estoque 
    { 
        get { return _estoque; }
        set 
        {
            _estoque = (value >= 0) ? value : throw new ArgumentOutOfRangeException($"O estoque não pode ser negativo!");
        } 
    }
    public double Preco
    {
        get { return _preco; }
        set
        {
            _preco = (double)((value >= 0) ? value : throw new ArgumentOutOfRangeException($"O preco não pode ser negativo!"));
        }
    }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Descrição => $"Produto: {Nome} \n Marca: {Marca} \nEstoque: {Estoque} \nPreço unitário: {Preco} \nPreço total: {Preco*Estoque}";
}