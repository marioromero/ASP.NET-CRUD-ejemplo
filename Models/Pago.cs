using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudASPEjemplo.Models
{
    public class Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "#")]
        public int id { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public int Monto { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:MM/DD/yyy")]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        [Display(Name = "Pagado")]
        public string EsEfectuado { get; set; }
    }
}