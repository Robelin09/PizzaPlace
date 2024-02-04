
namespace PizzaPlace.Modelos
{
    public class Estado
    {
        public Menu Menu { get; set; } = new Menu();
        public CestadeCompra Cesta { get; } = new CestadeCompra();
        public InterfazdeUsuario InterfazdeUsuario { get; set; } = new InterfazdeUsuario();

        public decimal PrecioTotal => Cesta.Pedidos.Sum(id => Menu.ObtenerPizza(id)!.Precio);
    }
}
