using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrtDriver.Models
{
    public class Viaje
    {
        public int Id { get; set; }
        public Conductor Conductor { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        [Display(Name = "Fecha de reserva")]
        public DateTime FechaInscripto { get; set; }

    }
}
