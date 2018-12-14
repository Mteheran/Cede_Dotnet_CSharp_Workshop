namespace Cede_Dotnet_CSharp_Workshop_Interfaces.Animales
{
    public class Gato : IAnimal
    {
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public string Clase { get; set; }

        public Gato()
        {
            Nombre = "Gato";
            Familia = "Felinos";
            Clase = "Mamífero";
        }
    }
}
