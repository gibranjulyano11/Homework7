namespace VintageStuff.Models
{
    public class Fabrica
    {
        public Camiseta CrearCamiseta(string marca = "Zero", string modelo = "Polo")
        {
            Camiseta camiseta = new Camiseta(marca, modelo);
            return camiseta;
        }
    }
}
