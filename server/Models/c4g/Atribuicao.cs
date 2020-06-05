using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("atribuicao", Schema = "dbo")]
  public partial class Atribuicao
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_atribuicao
    {
      get;
      set;
    }
    public int id_recursos
    {
      get;
      set;
    }
    public Recurso Recurso { get; set; }
    public int id_servico
    {
      get;
      set;
    }
    public Servico Servico { get; set; }
  }
}
