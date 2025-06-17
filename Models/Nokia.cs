namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia {Numero}.");
        }

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
    }
}