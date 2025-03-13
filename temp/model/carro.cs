public class Carro : Veiculo
{
    private int quantidadePortas;
    public int QuantidadePortas
    {
        get { return quantidadePortas; }
        set { quantidadePortas = value; }
    }
    public Carro(string marca, string modelo, int anoFabricacao, int quantidadePortas) : base(marca, modelo, anoFabricacao)
    {
        this.quantidadePortas = quantidadePortas;
    }
    public Carro() : base()
    {
        quantidadePortas = 0;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano de Fabricação: " + AnoFabricacao);
        Console.WriteLine("Número de Portas: " + quantidadePortas);
    }
}