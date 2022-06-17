using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrtDriver.Models
{
    public class Conductor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ConductorId { get; set; }
        public string ConductorName { get; set; }
        public string ConductorSurname { get; set; }
        public int Dni { get; set; }
        
        [Display(Name = "Fecha inscripción")]
        public DateTime FechaInscripto { get; set; }

    }
}
