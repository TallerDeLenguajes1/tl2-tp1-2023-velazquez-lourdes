using System.Collections.Specialized;

namespace cadeteria
{
    class Cliente
    {
        private string ?nombre;
        private string ?direccion;
        private int telefono;
        private string ?datoCliente;

        public Cliente(){}
        public Cliente(string nom, string dir, int tel, string datCli)
        {
            this.Nombre = nom;
            this.Direccion = dir;
            this.Telefono = tel;
            this.DatoCliente = datCli;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string DatoCliente { get => datoCliente; set => datoCliente = value; }

        
         public string VerDireccionCliente ( Cliente cli)
        {
            return cli.Direccion;
        }
    public string VerDatosCliente ( Cliente cli)
        {
            return cli.DatoCliente;
        }

    }
   

}