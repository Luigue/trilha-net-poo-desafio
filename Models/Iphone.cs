namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"


    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone {Numero}.");
        }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
    }
}