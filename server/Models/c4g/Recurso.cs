using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("recursos", Schema = "dbo")]
  public partial class Recurso
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_recursos
    {
      get;
      set;
    }

    public ICollection<Equipamento> Equipamentos { get; set; }
    public ICollection<Dado> Dados { get; set; }
    public ICollection<RecursosHumano> RecursosHumanos { get; set; }
    public ICollection<Formaco> Formacos { get; set; }
    public ICollection<Produto> Produtos { get; set; }
    public ICollection<Atribuicao> Atribuicaos { get; set; }
    public ICollection<Indisponibilidade> Indisponibilidades { get; set; }
  }
}
