namespace Domain
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }

        public Client(int id, string nom, string ape, string fecha, string dire)
        {
            this.IdClient = id;
            this.Nombre = nom;
            this.Apellido = ape;
            this.Fecha_Nacimiento = fecha;
            this.Direccion = dire;
        }
        public Client() { }
    }
}
