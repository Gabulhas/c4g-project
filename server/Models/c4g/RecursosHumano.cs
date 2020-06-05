using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("recursos_humanos", Schema = "dbo")]
  public partial class RecursosHumano
  {
    public string nome
    {
      get;
      set;
    }
    public string funcao
    {
      get;
      set;
    }
    public int id_lab
    {
      get;
      set;
    }
    public Laboratorio Laboratorio { get; set; }
    [Key]
    public int id_recursos
    {
      get;
      set;
    }
    public Recurso Recurso { get; set; }
  }
}
