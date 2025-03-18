
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gestor_de_rh01.BD.Domain.Entities
{

    //-----------------------------------------------------------------------------------
    [Table("TelegramaEn")]
    public class TelegramaEn
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Stdge { get; set; }
        public string Nomtelegrama { get; set; }
        public string Cedt { get; set; }
        public string Jlabt { get; set; }
        public string LugTrabt { get; set; }
        public string Fechat { get; set; }


    }
}