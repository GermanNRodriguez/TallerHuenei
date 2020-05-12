namespace Domain
{
    public class Combos
    {
        public int Cantidad { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }

        public Combos(int idC, int idP, int cantP )
        {
            this.Cantidad = cantP;
            this.IdCliente = idC;
            this.IdProducto = idP;
        }
        public Combos() { }

    }
}
