using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaBackend.Dtos
{
 
    public class ClienteDto
    {
        public int IdCliente { get; set; }
        [Required(ErrorMessage ="Nombre del cliente es requerido")]
        public string NombreCliente { get; set;}
        [EmailAddress(ErrorMessage ="La dirección de correo electrónico no es válido")]
        public string CorreoCliente { get; set; }
    }
}
