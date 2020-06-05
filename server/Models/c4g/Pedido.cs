using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("pedido", Schema = "dbo")]
  public partial class Pedido
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_pedido
    {
      get;
      set;
    }

    public ICollection<Indisponibilidade> Indisponibilidades { get; set; }
    public DateTime order_date
    {
      get;
      set;
    }
    public DateTime end_date
    {
      get;
      set;
    }
    public DateTime start_date
    {
      get;
      set;
    }
    public int id_servico
    {
      get;
      set;
    }
    public Servico Servico { get; set; }
    public int id_pessoa
    {
      get;
      set;
    }
    public Pessoa Pessoa { get; set; }
  }
}
