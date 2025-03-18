using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gestor_de_rh01.BD.Domain.Entities
{

    //-----------------------------------------------------------------------------------
    [Table("Listacompra")]
    public class Listacompra
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombreact { get; set; }
        public string Categ { get; set; }
        public string Cantidad22 { get; set; }
        public string Nomar { get; set; }
        public string Lugd { get; set; }
        public string Fechalist { get; set;}
    }
}