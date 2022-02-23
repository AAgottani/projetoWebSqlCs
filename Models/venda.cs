using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoWebSqlCs;

public class venda{
    [ForeignKey("id_veiculo")]

    public int fk_proprietario { get; set; }

    //w

    
}