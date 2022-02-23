using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoWebSqlCs;

public class Veiculo{

[Key]
[Required]
public int id_veiculo{ get; set; }
public string chassi{ get; set; }
public string modelo{ get; set; }
public int ano{ get; set; }
public string cor{ get; set; }

[ForeignKey("id_proprietario")]
public int fk_proprietario{ get; set; }

public double valor{ get; set; }
public double quilometragem{ get; set; }

public string versao_sistema{ get; set; }

}