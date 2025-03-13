public class Moto : Veiculo
{
    private int cilindradas;
    public int Cilindradas
    {
        get { return cilindradas; }
        set { cilindradas = value; }
    }
    public Moto(string marca, string modelo, int anoFabricacao, int cilindradas) : base(marca, modelo, anoFabricacao)
    {
        this.cilindradas = cilindradas;
    }
    public Moto() : base()
    {
        cilindradas = 0;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano de Fabricação: " + AnoFabricacao);
        Console.WriteLine("Cilindradas: " + cilindradas);
    }
}