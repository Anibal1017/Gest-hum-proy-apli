using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gestor_de_rh01.BD.Domain.Entities
{
    //f
    [Table("GestorRhh")]
    public class GestorRhh
    {

        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string cedula { get; set; }
        public string Fecha { get; set; }
        public string Cargo { get; set; }
        public string lugar_de_trabajo { get; set; }
        public string Sueldo_bruto { get; set; }
        public string a_en_servicios { get; set; }

    }
}

