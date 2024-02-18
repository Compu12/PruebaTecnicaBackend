using System;
using System.Collections.Generic;

namespace PruebaTecnicaBackend.Models
{
    public partial class ClienteServicio
    {
        public int IdClienteServicios { get; set; }
        public int IdCliente { get; set; }
        public int IdServicio { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual Servicio IdServicioNavigation { get; set; } = null!;
    }
}
