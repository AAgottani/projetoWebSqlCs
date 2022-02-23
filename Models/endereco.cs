using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoWebSqlCs;

public class endereco{

    public string cidade { get; set; }

    public string bairro { get; set; }

    public string rua { get; set; }

    public string numero { get; set; }

    [ForeignKey("id_proprietario")]

    public int fk_proprietario { get; set; }


}