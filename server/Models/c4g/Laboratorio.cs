using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("laboratorios", Schema = "dbo")]
  public partial class Laboratorio
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_lab
    {
      get;
      set;
    }

    public ICollection<Equipamento> Equipamentos { get; set; }
    public ICollection<Dado> Dados { get; set; }
    public ICollection<RecursosHumano> RecursosHumanos { get; set; }
    public ICollection<Formaco> Formacos { get; set; }
    public ICollection<Produto> Produtos { get; set; }
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
    public string grupo
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
