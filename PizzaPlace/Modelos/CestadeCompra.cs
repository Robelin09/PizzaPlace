using System.Collections.Generic;

namespace PizzaPlace.Modelos
{
    public class CestadeCompra
    {
        public Clientes Clientes { get; set; } = new Clientes();
        public List<int> Pedidos { get; set; } = new List<int>();

        public bool Pago { get; set; }

        public void Add(int PizzaId) => Pedidos.Add(PizzaId);

        public void EliminarEn(int pos) => Pedidos.RemoveAt(pos);
    }
}
