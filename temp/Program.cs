public class Program
{
    public static void Main()
    {
        Veiculo carro = new Carro("Chevrolet", "Cruze", 2019, 4);
        carro.ExibirInformacoes();
        Veiculo moto = new Moto("Honda", "CB 500", 2020, 500);
        moto.ExibirInformacoes();
    }
}