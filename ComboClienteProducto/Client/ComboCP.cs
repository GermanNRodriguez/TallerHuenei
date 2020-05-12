using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ComboCP
    {
        public string NombreC { get; set; }
        public string Apellido { get; set; }
        public string NombreP { get; set; }
        public int PrecioP { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }

        public ComboCP(string nomc, string ape, string nomp, int pre, int cant, int tot)
        {
            this.NombreC = nomc;
            this.Apellido = ape;
            this.NombreP = nomp;
            this.PrecioP = pre;
            this.Cantidad = cant;
            this.Total = tot;
        }

        public ComboCP() { }
    }
}
