using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gestor_de_rh01.BD.Domain.Entities
{

    //-----------------------------------------------------------------------------------
    [Table("Loginrh")]
    public class Loginrh
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string Niveladmin { get; set; } 

    }
}