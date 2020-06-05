using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("indisponibilidade", Schema = "dbo")]
  public partial class Indisponibilidade
  {
    public DateTime start_date
    {
      get;
      set;
    }
    public DateTime end_date
    {
      get;
      set;
    }
    [Key]
    public int id_pedido
    {
      get;
      set;
    }
    public Pedido Pedido { get; set; }
    [Key]
    public int id_recursos
    {
      get;
      set;
    }
    public Recurso Recurso { get; set; }
  }
}
