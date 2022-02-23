using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoWebSqlCs;

public class telefone{

    [ForeignKey("id_proprietario")]

    public int fk_proprietario { get; set; }

    public string numero { get; set; }


}