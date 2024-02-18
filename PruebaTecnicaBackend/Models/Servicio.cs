using System;
using System.Collections.Generic;

namespace PruebaTecnicaBackend.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            ClienteServicios = new HashSet<ClienteServicio>();
        }

        public int IdServicio { get; set; }
        public string NombreServicio { get; set; } = null!;
        public string DescripcionServicio { get; set; } = null!;

        public virtual ICollection<ClienteServicio> ClienteServicios { get; set; }
    }
}
