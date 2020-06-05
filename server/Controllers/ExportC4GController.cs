using Microsoft.AspNetCore.Mvc;
using C4G.Data;

namespace C4G
{
    public partial class ExportC4GController : ExportController
    {
        private readonly C4GContext context;

        public ExportC4GController(C4GContext context)
        {
            this.context = context;
        }

        [HttpGet("/export/C4G/atribuicaos/csv")]
        public FileStreamResult ExportAtribuicaosToCSV()
        {
            return ToCSV(ApplyQuery(context.Atribuicaos, Request.Query));
        }

        [HttpGet("/export/C4G/atribuicaos/excel")]
        public FileStreamResult ExportAtribuicaosToExcel()
        {
            return ToExcel(ApplyQuery(context.Atribuicaos, Request.Query));
        }

        [HttpGet("/export/C4G/dados/csv")]
        public FileStreamResult ExportDadosToCSV()
        {
            return ToCSV(ApplyQuery(context.Dados, Request.Query));
        }

        [HttpGet("/export/C4G/dados/excel")]
        public FileStreamResult ExportDadosToExcel()
        {
            return ToExcel(ApplyQuery(context.Dados, Request.Query));
        }

        [HttpGet("/export/C4G/equipamentos/csv")]
        public FileStreamResult ExportEquipamentosToCSV()
        {
            return ToCSV(ApplyQuery(context.Equipamentos, Request.Query));
        }

        [HttpGet("/export/C4G/equipamentos/excel")]
        public FileStreamResult ExportEquipamentosToExcel()
        {
            return ToExcel(ApplyQuery(context.Equipamentos, Request.Query));
        }

        [HttpGet("/export/C4G/formacos/csv")]
        public FileStreamResult ExportFormacosToCSV()
        {
            return ToCSV(ApplyQuery(context.Formacos, Request.Query));
        }

        [HttpGet("/export/C4G/formacos/excel")]
        public FileStreamResult ExportFormacosToExcel()
        {
            return ToExcel(ApplyQuery(context.Formacos, Request.Query));
        }

        [HttpGet("/export/C4G/indisponibilidades/csv")]
        public FileStreamResult ExportIndisponibilidadesToCSV()
        {
            return ToCSV(ApplyQuery(context.Indisponibilidades, Request.Query));
        }

        [HttpGet("/export/C4G/indisponibilidades/excel")]
        public FileStreamResult ExportIndisponibilidadesToExcel()
        {
            return ToExcel(ApplyQuery(context.Indisponibilidades, Request.Query));
        }

        [HttpGet("/export/C4G/instituicos/csv")]
        public FileStreamResult ExportInstituicosToCSV()
        {
            return ToCSV(ApplyQuery(context.Instituicos, Request.Query));
        }

        [HttpGet("/export/C4G/instituicos/excel")]
        public FileStreamResult ExportInstituicosToExcel()
        {
            return ToExcel(ApplyQuery(context.Instituicos, Request.Query));
        }

        [HttpGet("/export/C4G/laboratorios/csv")]
        public FileStreamResult ExportLaboratoriosToCSV()
        {
            return ToCSV(ApplyQuery(context.Laboratorios, Request.Query));
        }

        [HttpGet("/export/C4G/laboratorios/excel")]
        public FileStreamResult ExportLaboratoriosToExcel()
        {
            return ToExcel(ApplyQuery(context.Laboratorios, Request.Query));
        }

        [HttpGet("/export/C4G/pedidos/csv")]
        public FileStreamResult ExportPedidosToCSV()
        {
            return ToCSV(ApplyQuery(context.Pedidos, Request.Query));
        }

        [HttpGet("/export/C4G/pedidos/excel")]
        public FileStreamResult ExportPedidosToExcel()
        {
            return ToExcel(ApplyQuery(context.Pedidos, Request.Query));
        }

        [HttpGet("/export/C4G/pessoas/csv")]
        public FileStreamResult ExportPessoasToCSV()
        {
            return ToCSV(ApplyQuery(context.Pessoas, Request.Query));
        }

        [HttpGet("/export/C4G/pessoas/excel")]
        public FileStreamResult ExportPessoasToExcel()
        {
            return ToExcel(ApplyQuery(context.Pessoas, Request.Query));
        }

        [HttpGet("/export/C4G/produtos/csv")]
        public FileStreamResult ExportProdutosToCSV()
        {
            return ToCSV(ApplyQuery(context.Produtos, Request.Query));
        }

        [HttpGet("/export/C4G/produtos/excel")]
        public FileStreamResult ExportProdutosToExcel()
        {
            return ToExcel(ApplyQuery(context.Produtos, Request.Query));
        }

        [HttpGet("/export/C4G/recursos/csv")]
        public FileStreamResult ExportRecursosToCSV()
        {
            return ToCSV(ApplyQuery(context.Recursos, Request.Query));
        }

        [HttpGet("/export/C4G/recursos/excel")]
        public FileStreamResult ExportRecursosToExcel()
        {
            return ToExcel(ApplyQuery(context.Recursos, Request.Query));
        }

        [HttpGet("/export/C4G/recursoshumanos/csv")]
        public FileStreamResult ExportRecursosHumanosToCSV()
        {
            return ToCSV(ApplyQuery(context.RecursosHumanos, Request.Query));
        }

        [HttpGet("/export/C4G/recursoshumanos/excel")]
        public FileStreamResult ExportRecursosHumanosToExcel()
        {
            return ToExcel(ApplyQuery(context.RecursosHumanos, Request.Query));
        }

        [HttpGet("/export/C4G/servicos/csv")]
        public FileStreamResult ExportServicosToCSV()
        {
            return ToCSV(ApplyQuery(context.Servicos, Request.Query));
        }

        [HttpGet("/export/C4G/servicos/excel")]
        public FileStreamResult ExportServicosToExcel()
        {
            return ToExcel(ApplyQuery(context.Servicos, Request.Query));
        }
    }
}
