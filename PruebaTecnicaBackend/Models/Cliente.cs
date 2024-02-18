using System;
using System.Collections.Generic;

namespace PruebaTecnicaBackend.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienteServicios = new HashSet<ClienteServicio>();
        }

        public int IdCliente { get; set; }
        public string? NombreCliente { get; set; }
        public string? CorreoCliente { get; set; }

        public virtual ICollection<ClienteServicio> ClienteServicios { get; set; }
    }
}
