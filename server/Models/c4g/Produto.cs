using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("produtos", Schema = "dbo")]
  public partial class Produto
  {
    public string designacao_PT
    {
      get;
      set;
    }
    public string designacao_EN
    {
      get;
      set;
    }
    public int nivel
    {
      get;
      set;
    }
    public string tipo_produto
    {
      get;
      set;
    }
    public string webpage
    {
      get;
      set;
    }
    public string observacoes
    {
      get;
      set;
    }
    public double custo_unitario
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
