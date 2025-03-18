using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace gestor_de_rh01.BD.Domain.Entities
{

    [Table("Personalrhh")]

    public class Personalrhh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreP { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Dvive { get; set; }

        public string Genero { get; set; }

        public string area_trabajo { get; set; }

    }
}
