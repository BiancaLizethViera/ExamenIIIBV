using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El Campo Id Usuario es Obligatorio")] 
        public string idUsuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set;}
    }
}