namespace PizzaPlace.Modelos
{
    public class Pizzas
    {
        public int Id { get;}
        public string Nombre { get;}
        public decimal Precio { get;}
        public Picantes Picantes { get;}
        public Pizzas(int id, string nombre, decimal precio, Picantes picantes)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Picantes = picantes;
        }
    }
}
