using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("instituicoes", Schema = "dbo")]
  public partial class Instituico
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_instituicao
    {
      get;
      set;
    }

    public ICollection<Pessoa> Pessoas { get; set; }
    public ICollection<Laboratorio> Laboratorios { get; set; }
    public string designacao
    {
      get;
      set;
    }
    public string acronimo
    {
      get;
      set;
    }
  }
}
