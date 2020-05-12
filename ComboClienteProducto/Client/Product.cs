namespace Domain
{
    public class Product
    {
        public int IdProduc { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public Product(int id, string nom, string desc, int pre, int st)
        {
            this.IdProduc = id;
            this.Nombre = nom;
            this.Descripcion = desc;
            this.Precio = pre;
            this.Stock = st;
        }
        public Product() { }
    }
}
