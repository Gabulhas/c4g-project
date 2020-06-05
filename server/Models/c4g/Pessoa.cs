using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("pessoa", Schema = "dbo")]
  public partial class Pessoa
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_pessoa
    {
      get;
      set;
    }

    public ICollection<Servico> Servicos { get; set; }
    public ICollection<Pedido> Pedidos { get; set; }
    public string nome
    {
      get;
      set;
    }
    public string morada
    {
      get;
      set;
    }
    public string email
    {
      get;
      set;
    }
    public int id_instituicao
    {
      get;
      set;
    }
    public Instituico Instituico { get; set; }
  }
}
