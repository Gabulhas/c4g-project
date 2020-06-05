using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C4G.Models.C4G
{
  [Table("equipamentos", Schema = "dbo")]
  public partial class Equipamento
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
    public DateTime data_registo
    {
      get;
      set;
    }
    public int num_registo
    {
      get;
      set;
    }
    public string observacoes
    {
      get;
      set;
    }
    public string foto_equipamento
    {
      get;
      set;
    }
    public string unidade_investigacao
    {
      get;
      set;
    }
    public string marca
    {
      get;
      set;
    }
    public string modelo
    {
      get;
      set;
    }
    public int num_serie
    {
      get;
      set;
    }
    public int garantia
    {
      get;
      set;
    }
    public string tipo_uso
    {
      get;
      set;
    }
    public string condicao_uso
    {
      get;
      set;
    }
    public string mobilidade
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
