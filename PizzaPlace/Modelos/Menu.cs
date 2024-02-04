using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Modelos
{
    public class Menu
    {
        public List<Pizzas> Pizzas { get; set; }
        = new List<Pizzas>();

        public void Add(Pizzas pizzas) => Pizzas.Add(pizzas);

        public Pizzas? ObtenerPizza(int id) => Pizzas.SingleOrDefault(pizzas => pizzas.Id == id);
    }
}
