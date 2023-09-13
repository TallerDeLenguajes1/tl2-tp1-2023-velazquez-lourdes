namespace cadeteria
{
    class Cadeteria
    {
        private string nombre;
        private int telefono;
        private List<Cadete> listadoCadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
        public Cadeteria ()
        {
            listadoCadetes = new List<Cadete>();
        } 
        public Cadeteria(string nom, int tel)
        {
            this.Nombre = nom;
            this.Telefono = tel;
            this.ListadoCadetes = new List<Cadete>();
        }

    }
}