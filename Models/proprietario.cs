using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoWebSqlCs;

public class Proprietario{
    [Key]
    [Required]
    public int id_proprietario{ get; set; }
    
    public string nome { get; set; }

    

    [ForeignKey("id_documento")]
     public int fk_documento{ get; set; }

     [ForeignKey("id_veiculo")]
     public int fk_veiculo{ get; set; }


}