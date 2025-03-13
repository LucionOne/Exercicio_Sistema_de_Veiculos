public abstract class Veiculo
{
    private string? marca;
    private string? modelo; 
    private int anoFabricacao; 
    public string? Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public string? Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    public int AnoFabricacao
    {
        get { return anoFabricacao; }
        set { anoFabricacao = value; }
    }
    public Veiculo(string marca, string modelo, int anoFabricacao)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.anoFabricacao = anoFabricacao;
    }
    public Veiculo()
    {
        marca = "";
        modelo = "";
        anoFabricacao = 0;
    }
    public abstract void ExibirInformacoes();
}
