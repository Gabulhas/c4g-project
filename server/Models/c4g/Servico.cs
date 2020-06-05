using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("servicos", Schema = "dbo")]
  public partial class Servico
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_servico
    {
      get;
      set;
    }

    public ICollection<Atribuicao> Atribuicaos { get; set; }
    public ICollection<Pedido> Pedidos { get; set; }
    public string designacao
    {
      get;
      set;
    }
    public int supervisionador
    {
      get;
      set;
    }
    public Pessoa Pessoa { get; set; }
  }
}
