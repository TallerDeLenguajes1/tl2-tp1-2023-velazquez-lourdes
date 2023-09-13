namespace cadeteria
{
    class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private int telefono;
        private List<Pedido> listadoPedidos;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

        public Cadete()
        {
            ListadoPedidos = new List<Pedido>();
        }

        public Cadete(int id, string nom, string dir, int tel )
        {
            this.Id = id;
            this.Nombre = nom;
            this.Direccion = dir;
            ListadoPedidos = new List<Pedido>();
        }

        public float JornalACobrar(Cadete cad)
        {
            float total =0;
            int i=0;
            foreach (var item in cad.ListadoPedidos)
            {
                i++;
            }
            total = 500*i;
            return total; 
        }

        public void AgregarPedido (Pedido p)
        {
            ListadoPedidos.Add(p);
        }
    }
}