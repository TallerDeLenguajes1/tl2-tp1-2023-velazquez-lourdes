
namespace cadeteria
{
    enum Estado
    {
        etregedo ,
        pendiente
    }
    class Pedido
    {
        private int numero;
        private string? observacion;
        private Cliente cliente;
        private Estado estado;

        public int Numero { get => numero; set => numero = value; }
         public string Observacion { get => observacion; set => observacion = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Estado Estado { get => estado; set => estado = value; }
        
        public Pedido(){}
        public Pedido(int num, string obs, Cliente cli, Estado est, string nomCliente , string dirCliente, int telCliente, string datCliente )
        {
            this.Numero = num;
            this.Observacion = obs;
            Cliente = new Cliente( nomCliente ,  dirCliente, telCliente, datCliente );
            this.Estado = est;
        }
        
    }
}