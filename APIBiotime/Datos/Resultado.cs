using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace APIBiotime.Datos
{
    public class Resultado
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string tipoMarca { get; set; }
        public string fechahora  { get; set; }
        public string serial { get; set; }
        public string nombreReloj { get; set; }
    }
}
