using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Modelos
{
    public class Clientes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su nombre.")]
        public string Nombre { get; set; } = default!;

        [Required(ErrorMessage = "Proporcione una calle con el número de la casa.")]
        public string Calle { get; set; } = default!;

        [Required(ErrorMessage = "Proporcione su ciudad.")]
        public string Ciudad { get; set; } = default!;
    }
}
