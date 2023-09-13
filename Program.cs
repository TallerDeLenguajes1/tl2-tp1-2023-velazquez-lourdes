
using cadeteria;
namespace cadeteria
{
    internal class Program
{
    private static void Main(string[] args)
    {
        Cliente c1 = new Cliente();
        c1.Nombre = "Cliente1";
        c1.Direccion = "Dir1";
        c1.Telefono = 123456789;
        c1.DatoCliente = "Datos1";
        Pedido p1 = new Pedido();
        p1.Cliente = c1;
        p1.Estado = Estado.pendiente;
        p1.Numero = 1;
        p1.Observacion = "pedido1";
        Cadete cad = new Cadete();
        cad.Direccion = "dir cadete ";
        cad.Id = 1;
        cad.AgregarPedido(p1); // error se rompe !!!!
        cad.Nombre = "NombreCadete";
        Cadeteria cadeteri1 = new Cadeteria();
        cadeteri1.Nombre = "Nombre de la cadeteria";
        cadeteri1.Telefono = 11111;
        cadeteri1.ListadoCadetes.Add(cad); //error se rompe !!!!
    }
}
}
