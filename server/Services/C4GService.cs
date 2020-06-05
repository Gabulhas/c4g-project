using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using C4G.Data;

namespace C4G
{
    public partial class C4GService
    {
        private readonly C4GContext context;
        private readonly NavigationManager navigationManager;

        public C4GService(C4GContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportAtribuicaosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/atribuicaos/excel") : "export/c4g/atribuicaos/excel", true);
        }

        public async Task ExportAtribuicaosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/atribuicaos/csv") : "export/c4g/atribuicaos/csv", true);
        }

        partial void OnAtribuicaosRead(ref IQueryable<Models.C4G.Atribuicao> items);

        public async Task<IQueryable<Models.C4G.Atribuicao>> GetAtribuicaos(Query query = null)
        {
            var items = context.Atribuicaos.AsQueryable();

            items = items.Include(i => i.Recurso);

            items = items.Include(i => i.Servico);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnAtribuicaosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnAtribuicaoCreated(Models.C4G.Atribuicao item);

        public async Task<Models.C4G.Atribuicao> CreateAtribuicao(Models.C4G.Atribuicao atribuicao)
        {
            OnAtribuicaoCreated(atribuicao);

            context.Atribuicaos.Add(atribuicao);
            context.SaveChanges();

            return atribuicao;
        }
        public async Task ExportDadosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/dados/excel") : "export/c4g/dados/excel", true);
        }

        public async Task ExportDadosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/dados/csv") : "export/c4g/dados/csv", true);
        }

        partial void OnDadosRead(ref IQueryable<Models.C4G.Dado> items);

        public async Task<IQueryable<Models.C4G.Dado>> GetDados(Query query = null)
        {
            var items = context.Dados.AsQueryable();

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnDadosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnDadoCreated(Models.C4G.Dado item);

        public async Task<Models.C4G.Dado> CreateDado(Models.C4G.Dado dado)
        {
            OnDadoCreated(dado);

            context.Dados.Add(dado);
            context.SaveChanges();

            return dado;
        }
        public async Task ExportEquipamentosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/equipamentos/excel") : "export/c4g/equipamentos/excel", true);
        }

        public async Task ExportEquipamentosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/equipamentos/csv") : "export/c4g/equipamentos/csv", true);
        }

        partial void OnEquipamentosRead(ref IQueryable<Models.C4G.Equipamento> items);

        public async Task<IQueryable<Models.C4G.Equipamento>> GetEquipamentos(Query query = null)
        {
            var items = context.Equipamentos.AsQueryable();

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnEquipamentosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnEquipamentoCreated(Models.C4G.Equipamento item);

        public async Task<Models.C4G.Equipamento> CreateEquipamento(Models.C4G.Equipamento equipamento)
        {
            OnEquipamentoCreated(equipamento);

            context.Equipamentos.Add(equipamento);
            context.SaveChanges();

            return equipamento;
        }
        public async Task ExportFormacosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/formacos/excel") : "export/c4g/formacos/excel", true);
        }

        public async Task ExportFormacosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/formacos/csv") : "export/c4g/formacos/csv", true);
        }

        partial void OnFormacosRead(ref IQueryable<Models.C4G.Formaco> items);

        public async Task<IQueryable<Models.C4G.Formaco>> GetFormacos(Query query = null)
        {
            var items = context.Formacos.AsQueryable();

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnFormacosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnFormacoCreated(Models.C4G.Formaco item);

        public async Task<Models.C4G.Formaco> CreateFormaco(Models.C4G.Formaco formaco)
        {
            OnFormacoCreated(formaco);

            context.Formacos.Add(formaco);
            context.SaveChanges();

            return formaco;
        }
        public async Task ExportIndisponibilidadesToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/indisponibilidades/excel") : "export/c4g/indisponibilidades/excel", true);
        }

        public async Task ExportIndisponibilidadesToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/indisponibilidades/csv") : "export/c4g/indisponibilidades/csv", true);
        }

        partial void OnIndisponibilidadesRead(ref IQueryable<Models.C4G.Indisponibilidade> items);

        public async Task<IQueryable<Models.C4G.Indisponibilidade>> GetIndisponibilidades(Query query = null)
        {
            var items = context.Indisponibilidades.AsQueryable();

            items = items.Include(i => i.Pedido);

            items = items.Include(i => i.Recurso);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnIndisponibilidadesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnIndisponibilidadeCreated(Models.C4G.Indisponibilidade item);

        public async Task<Models.C4G.Indisponibilidade> CreateIndisponibilidade(Models.C4G.Indisponibilidade indisponibilidade)
        {
            OnIndisponibilidadeCreated(indisponibilidade);

            context.Indisponibilidades.Add(indisponibilidade);
            context.SaveChanges();

            return indisponibilidade;
        }
        public async Task ExportInstituicosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/instituicos/excel") : "export/c4g/instituicos/excel", true);
        }

        public async Task ExportInstituicosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/instituicos/csv") : "export/c4g/instituicos/csv", true);
        }

        partial void OnInstituicosRead(ref IQueryable<Models.C4G.Instituico> items);

        public async Task<IQueryable<Models.C4G.Instituico>> GetInstituicos(Query query = null)
        {
            var items = context.Instituicos.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnInstituicosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnInstituicoCreated(Models.C4G.Instituico item);

        public async Task<Models.C4G.Instituico> CreateInstituico(Models.C4G.Instituico instituico)
        {
            OnInstituicoCreated(instituico);

            context.Instituicos.Add(instituico);
            context.SaveChanges();

            return instituico;
        }
        public async Task ExportLaboratoriosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/laboratorios/excel") : "export/c4g/laboratorios/excel", true);
        }

        public async Task ExportLaboratoriosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/laboratorios/csv") : "export/c4g/laboratorios/csv", true);
        }

        partial void OnLaboratoriosRead(ref IQueryable<Models.C4G.Laboratorio> items);

        public async Task<IQueryable<Models.C4G.Laboratorio>> GetLaboratorios(Query query = null)
        {
            var items = context.Laboratorios.AsQueryable();

            items = items.Include(i => i.Instituico);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnLaboratoriosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnLaboratorioCreated(Models.C4G.Laboratorio item);

        public async Task<Models.C4G.Laboratorio> CreateLaboratorio(Models.C4G.Laboratorio laboratorio)
        {
            OnLaboratorioCreated(laboratorio);

            context.Laboratorios.Add(laboratorio);
            context.SaveChanges();

            return laboratorio;
        }
        public async Task ExportPedidosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/pedidos/excel") : "export/c4g/pedidos/excel", true);
        }

        public async Task ExportPedidosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/pedidos/csv") : "export/c4g/pedidos/csv", true);
        }

        partial void OnPedidosRead(ref IQueryable<Models.C4G.Pedido> items);

        public async Task<IQueryable<Models.C4G.Pedido>> GetPedidos(Query query = null)
        {
            var items = context.Pedidos.AsQueryable();

            items = items.Include(i => i.Servico);

            items = items.Include(i => i.Pessoa);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnPedidosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnPedidoCreated(Models.C4G.Pedido item);

        public async Task<Models.C4G.Pedido> CreatePedido(Models.C4G.Pedido pedido)
        {
            OnPedidoCreated(pedido);

            context.Pedidos.Add(pedido);
            context.SaveChanges();

            return pedido;
        }
        public async Task ExportPessoasToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/pessoas/excel") : "export/c4g/pessoas/excel", true);
        }

        public async Task ExportPessoasToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/pessoas/csv") : "export/c4g/pessoas/csv", true);
        }

        partial void OnPessoasRead(ref IQueryable<Models.C4G.Pessoa> items);

        public async Task<IQueryable<Models.C4G.Pessoa>> GetPessoas(Query query = null)
        {
            var items = context.Pessoas.AsQueryable();

            items = items.Include(i => i.Instituico);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnPessoasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnPessoaCreated(Models.C4G.Pessoa item);

        public async Task<Models.C4G.Pessoa> CreatePessoa(Models.C4G.Pessoa pessoa)
        {
            OnPessoaCreated(pessoa);

            context.Pessoas.Add(pessoa);
            context.SaveChanges();

            return pessoa;
        }
        public async Task ExportProdutosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/produtos/excel") : "export/c4g/produtos/excel", true);
        }

        public async Task ExportProdutosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/produtos/csv") : "export/c4g/produtos/csv", true);
        }

        partial void OnProdutosRead(ref IQueryable<Models.C4G.Produto> items);

        public async Task<IQueryable<Models.C4G.Produto>> GetProdutos(Query query = null)
        {
            var items = context.Produtos.AsQueryable();

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnProdutosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnProdutoCreated(Models.C4G.Produto item);

        public async Task<Models.C4G.Produto> CreateProduto(Models.C4G.Produto produto)
        {
            OnProdutoCreated(produto);

            context.Produtos.Add(produto);
            context.SaveChanges();

            return produto;
        }
        public async Task ExportRecursosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/recursos/excel") : "export/c4g/recursos/excel", true);
        }

        public async Task ExportRecursosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/recursos/csv") : "export/c4g/recursos/csv", true);
        }

        partial void OnRecursosRead(ref IQueryable<Models.C4G.Recurso> items);

        public async Task<IQueryable<Models.C4G.Recurso>> GetRecursos(Query query = null)
        {
            var items = context.Recursos.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnRecursosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnRecursoCreated(Models.C4G.Recurso item);

        public async Task<Models.C4G.Recurso> CreateRecurso(Models.C4G.Recurso recurso)
        {
            OnRecursoCreated(recurso);

            context.Recursos.Add(recurso);
            context.SaveChanges();

            return recurso;
        }
        public async Task ExportRecursosHumanosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/recursoshumanos/excel") : "export/c4g/recursoshumanos/excel", true);
        }

        public async Task ExportRecursosHumanosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/recursoshumanos/csv") : "export/c4g/recursoshumanos/csv", true);
        }

        partial void OnRecursosHumanosRead(ref IQueryable<Models.C4G.RecursosHumano> items);

        public async Task<IQueryable<Models.C4G.RecursosHumano>> GetRecursosHumanos(Query query = null)
        {
            var items = context.RecursosHumanos.AsQueryable();

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnRecursosHumanosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnRecursosHumanoCreated(Models.C4G.RecursosHumano item);

        public async Task<Models.C4G.RecursosHumano> CreateRecursosHumano(Models.C4G.RecursosHumano recursosHumano)
        {
            OnRecursosHumanoCreated(recursosHumano);

            context.RecursosHumanos.Add(recursosHumano);
            context.SaveChanges();

            return recursosHumano;
        }
        public async Task ExportServicosToExcel(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/servicos/excel") : "export/c4g/servicos/excel", true);
        }

        public async Task ExportServicosToCSV(Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl("export/c4g/servicos/csv") : "export/c4g/servicos/csv", true);
        }

        partial void OnServicosRead(ref IQueryable<Models.C4G.Servico> items);

        public async Task<IQueryable<Models.C4G.Servico>> GetServicos(Query query = null)
        {
            var items = context.Servicos.AsQueryable();

            items = items.Include(i => i.Pessoa);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnServicosRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnServicoCreated(Models.C4G.Servico item);

        public async Task<Models.C4G.Servico> CreateServico(Models.C4G.Servico servico)
        {
            OnServicoCreated(servico);

            context.Servicos.Add(servico);
            context.SaveChanges();

            return servico;
        }

        partial void OnAtribuicaoDeleted(Models.C4G.Atribuicao item);

        public async Task<Models.C4G.Atribuicao> DeleteAtribuicao(int? idAtribuicao)
        {
            var item = context.Atribuicaos
                              .Where(i => i.id_atribuicao == idAtribuicao)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnAtribuicaoDeleted(item);

            context.Atribuicaos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnAtribuicaoGet(Models.C4G.Atribuicao item);

        public async Task<Models.C4G.Atribuicao> GetAtribuicaoByidAtribuicao(int? idAtribuicao)
        {
            var items = context.Atribuicaos
                              .AsNoTracking()
                              .Where(i => i.id_atribuicao == idAtribuicao);

            items = items.Include(i => i.Recurso);

            items = items.Include(i => i.Servico);

            var item = items.FirstOrDefault();

            OnAtribuicaoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Atribuicao> CancelAtribuicaoChanges(Models.C4G.Atribuicao item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnAtribuicaoUpdated(Models.C4G.Atribuicao item);

        public async Task<Models.C4G.Atribuicao> UpdateAtribuicao(int? idAtribuicao, Models.C4G.Atribuicao atribuicao)
        {
            OnAtribuicaoUpdated(atribuicao);

            var item = context.Atribuicaos
                              .Where(i => i.id_atribuicao == idAtribuicao)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(atribuicao);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return atribuicao;
        }

        partial void OnDadoDeleted(Models.C4G.Dado item);

        public async Task<Models.C4G.Dado> DeleteDado(int? idRecursos)
        {
            var item = context.Dados
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnDadoDeleted(item);

            context.Dados.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnDadoGet(Models.C4G.Dado item);

        public async Task<Models.C4G.Dado> GetDadoByidRecursos(int? idRecursos)
        {
            var items = context.Dados
                              .AsNoTracking()
                              .Where(i => i.id_recursos == idRecursos);

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            var item = items.FirstOrDefault();

            OnDadoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Dado> CancelDadoChanges(Models.C4G.Dado item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnDadoUpdated(Models.C4G.Dado item);

        public async Task<Models.C4G.Dado> UpdateDado(int? idRecursos, Models.C4G.Dado dado)
        {
            OnDadoUpdated(dado);

            var item = context.Dados
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(dado);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return dado;
        }

        partial void OnEquipamentoDeleted(Models.C4G.Equipamento item);

        public async Task<Models.C4G.Equipamento> DeleteEquipamento(int? idRecursos)
        {
            var item = context.Equipamentos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnEquipamentoDeleted(item);

            context.Equipamentos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnEquipamentoGet(Models.C4G.Equipamento item);

        public async Task<Models.C4G.Equipamento> GetEquipamentoByidRecursos(int? idRecursos)
        {
            var items = context.Equipamentos
                              .AsNoTracking()
                              .Where(i => i.id_recursos == idRecursos);

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            var item = items.FirstOrDefault();

            OnEquipamentoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Equipamento> CancelEquipamentoChanges(Models.C4G.Equipamento item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnEquipamentoUpdated(Models.C4G.Equipamento item);

        public async Task<Models.C4G.Equipamento> UpdateEquipamento(int? idRecursos, Models.C4G.Equipamento equipamento)
        {
            OnEquipamentoUpdated(equipamento);

            var item = context.Equipamentos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(equipamento);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return equipamento;
        }

        partial void OnFormacoDeleted(Models.C4G.Formaco item);

        public async Task<Models.C4G.Formaco> DeleteFormaco(int? idRecursos)
        {
            var item = context.Formacos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnFormacoDeleted(item);

            context.Formacos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnFormacoGet(Models.C4G.Formaco item);

        public async Task<Models.C4G.Formaco> GetFormacoByidRecursos(int? idRecursos)
        {
            var items = context.Formacos
                              .AsNoTracking()
                              .Where(i => i.id_recursos == idRecursos);

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            var item = items.FirstOrDefault();

            OnFormacoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Formaco> CancelFormacoChanges(Models.C4G.Formaco item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnFormacoUpdated(Models.C4G.Formaco item);

        public async Task<Models.C4G.Formaco> UpdateFormaco(int? idRecursos, Models.C4G.Formaco formaco)
        {
            OnFormacoUpdated(formaco);

            var item = context.Formacos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(formaco);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return formaco;
        }

        partial void OnIndisponibilidadeDeleted(Models.C4G.Indisponibilidade item);

        public async Task<Models.C4G.Indisponibilidade> DeleteIndisponibilidade(int? idPedido, int? idRecursos)
        {
            var item = context.Indisponibilidades
                              .Where(i => i.id_pedido == idPedido && i.id_recursos == idRecursos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnIndisponibilidadeDeleted(item);

            context.Indisponibilidades.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnIndisponibilidadeGet(Models.C4G.Indisponibilidade item);

        public async Task<Models.C4G.Indisponibilidade> GetIndisponibilidadeByIdPedidoAndIdRecursos(int? idPedido, int? idRecursos)
        {
            var items = context.Indisponibilidades
                              .AsNoTracking()
                              .Where(i => i.id_pedido == idPedido && i.id_recursos == idRecursos);

            items = items.Include(i => i.Pedido);

            items = items.Include(i => i.Recurso);

            var item = items.FirstOrDefault();

            OnIndisponibilidadeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Indisponibilidade> CancelIndisponibilidadeChanges(Models.C4G.Indisponibilidade item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnIndisponibilidadeUpdated(Models.C4G.Indisponibilidade item);

        public async Task<Models.C4G.Indisponibilidade> UpdateIndisponibilidade(int? idPedido, int? idRecursos, Models.C4G.Indisponibilidade indisponibilidade)
        {
            OnIndisponibilidadeUpdated(indisponibilidade);

            var item = context.Indisponibilidades
                              .Where(i => i.id_pedido == idPedido && i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(indisponibilidade);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return indisponibilidade;
        }

        partial void OnInstituicoDeleted(Models.C4G.Instituico item);

        public async Task<Models.C4G.Instituico> DeleteInstituico(int? idInstituicao)
        {
            var item = context.Instituicos
                              .Where(i => i.id_instituicao == idInstituicao)
                              .Include(i => i.Pessoas)
                              .Include(i => i.Laboratorios)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnInstituicoDeleted(item);

            context.Instituicos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnInstituicoGet(Models.C4G.Instituico item);

        public async Task<Models.C4G.Instituico> GetInstituicoByidInstituicao(int? idInstituicao)
        {
            var items = context.Instituicos
                              .AsNoTracking()
                              .Where(i => i.id_instituicao == idInstituicao);

            var item = items.FirstOrDefault();

            OnInstituicoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Instituico> CancelInstituicoChanges(Models.C4G.Instituico item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnInstituicoUpdated(Models.C4G.Instituico item);

        public async Task<Models.C4G.Instituico> UpdateInstituico(int? idInstituicao, Models.C4G.Instituico instituico)
        {
            OnInstituicoUpdated(instituico);

            var item = context.Instituicos
                              .Where(i => i.id_instituicao == idInstituicao)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(instituico);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return instituico;
        }

        partial void OnLaboratorioDeleted(Models.C4G.Laboratorio item);

        public async Task<Models.C4G.Laboratorio> DeleteLaboratorio(int? idLab)
        {
            var item = context.Laboratorios
                              .Where(i => i.id_lab == idLab)
                              .Include(i => i.Equipamentos)
                              .Include(i => i.Dados)
                              .Include(i => i.RecursosHumanos)
                              .Include(i => i.Formacos)
                              .Include(i => i.Produtos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnLaboratorioDeleted(item);

            context.Laboratorios.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnLaboratorioGet(Models.C4G.Laboratorio item);

        public async Task<Models.C4G.Laboratorio> GetLaboratorioByidLab(int? idLab)
        {
            var items = context.Laboratorios
                              .AsNoTracking()
                              .Where(i => i.id_lab == idLab);

            items = items.Include(i => i.Instituico);

            var item = items.FirstOrDefault();

            OnLaboratorioGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Laboratorio> CancelLaboratorioChanges(Models.C4G.Laboratorio item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnLaboratorioUpdated(Models.C4G.Laboratorio item);

        public async Task<Models.C4G.Laboratorio> UpdateLaboratorio(int? idLab, Models.C4G.Laboratorio laboratorio)
        {
            OnLaboratorioUpdated(laboratorio);

            var item = context.Laboratorios
                              .Where(i => i.id_lab == idLab)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(laboratorio);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return laboratorio;
        }

        partial void OnPedidoDeleted(Models.C4G.Pedido item);

        public async Task<Models.C4G.Pedido> DeletePedido(int? idPedido)
        {
            var item = context.Pedidos
                              .Where(i => i.id_pedido == idPedido)
                              .Include(i => i.Indisponibilidades)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnPedidoDeleted(item);

            context.Pedidos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnPedidoGet(Models.C4G.Pedido item);

        public async Task<Models.C4G.Pedido> GetPedidoByidPedido(int? idPedido)
        {
            var items = context.Pedidos
                              .AsNoTracking()
                              .Where(i => i.id_pedido == idPedido);

            items = items.Include(i => i.Servico);

            items = items.Include(i => i.Pessoa);

            var item = items.FirstOrDefault();

            OnPedidoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Pedido> CancelPedidoChanges(Models.C4G.Pedido item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnPedidoUpdated(Models.C4G.Pedido item);

        public async Task<Models.C4G.Pedido> UpdatePedido(int? idPedido, Models.C4G.Pedido pedido)
        {
            OnPedidoUpdated(pedido);

            var item = context.Pedidos
                              .Where(i => i.id_pedido == idPedido)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(pedido);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return pedido;
        }

        partial void OnPessoaDeleted(Models.C4G.Pessoa item);

        public async Task<Models.C4G.Pessoa> DeletePessoa(int? idPessoa)
        {
            var item = context.Pessoas
                              .Where(i => i.id_pessoa == idPessoa)
                              .Include(i => i.Servicos)
                              .Include(i => i.Pedidos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnPessoaDeleted(item);

            context.Pessoas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnPessoaGet(Models.C4G.Pessoa item);

        public async Task<Models.C4G.Pessoa> GetPessoaByidPessoa(int? idPessoa)
        {
            var items = context.Pessoas
                              .AsNoTracking()
                              .Where(i => i.id_pessoa == idPessoa);

            items = items.Include(i => i.Instituico);

            var item = items.FirstOrDefault();

            OnPessoaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Pessoa> CancelPessoaChanges(Models.C4G.Pessoa item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnPessoaUpdated(Models.C4G.Pessoa item);

        public async Task<Models.C4G.Pessoa> UpdatePessoa(int? idPessoa, Models.C4G.Pessoa pessoa)
        {
            OnPessoaUpdated(pessoa);

            var item = context.Pessoas
                              .Where(i => i.id_pessoa == idPessoa)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(pessoa);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return pessoa;
        }

        partial void OnProdutoDeleted(Models.C4G.Produto item);

        public async Task<Models.C4G.Produto> DeleteProduto(int? idRecursos)
        {
            var item = context.Produtos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnProdutoDeleted(item);

            context.Produtos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnProdutoGet(Models.C4G.Produto item);

        public async Task<Models.C4G.Produto> GetProdutoByidRecursos(int? idRecursos)
        {
            var items = context.Produtos
                              .AsNoTracking()
                              .Where(i => i.id_recursos == idRecursos);

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            var item = items.FirstOrDefault();

            OnProdutoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Produto> CancelProdutoChanges(Models.C4G.Produto item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnProdutoUpdated(Models.C4G.Produto item);

        public async Task<Models.C4G.Produto> UpdateProduto(int? idRecursos, Models.C4G.Produto produto)
        {
            OnProdutoUpdated(produto);

            var item = context.Produtos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(produto);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return produto;
        }

        partial void OnRecursoDeleted(Models.C4G.Recurso item);

        public async Task<Models.C4G.Recurso> DeleteRecurso(int? idRecursos)
        {
            var item = context.Recursos
                              .Where(i => i.id_recursos == idRecursos)
                              .Include(i => i.Equipamentos)
                              .Include(i => i.Dados)
                              .Include(i => i.RecursosHumanos)
                              .Include(i => i.Formacos)
                              .Include(i => i.Produtos)
                              .Include(i => i.Atribuicaos)
                              .Include(i => i.Indisponibilidades)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnRecursoDeleted(item);

            context.Recursos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnRecursoGet(Models.C4G.Recurso item);

        public async Task<Models.C4G.Recurso> GetRecursoByidRecursos(int? idRecursos)
        {
            var items = context.Recursos
                              .AsNoTracking()
                              .Where(i => i.id_recursos == idRecursos);

            var item = items.FirstOrDefault();

            OnRecursoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Recurso> CancelRecursoChanges(Models.C4G.Recurso item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnRecursoUpdated(Models.C4G.Recurso item);

        public async Task<Models.C4G.Recurso> UpdateRecurso(int? idRecursos, Models.C4G.Recurso recurso)
        {
            OnRecursoUpdated(recurso);

            var item = context.Recursos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(recurso);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return recurso;
        }

        partial void OnRecursosHumanoDeleted(Models.C4G.RecursosHumano item);

        public async Task<Models.C4G.RecursosHumano> DeleteRecursosHumano(int? idRecursos)
        {
            var item = context.RecursosHumanos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnRecursosHumanoDeleted(item);

            context.RecursosHumanos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnRecursosHumanoGet(Models.C4G.RecursosHumano item);

        public async Task<Models.C4G.RecursosHumano> GetRecursosHumanoByidRecursos(int? idRecursos)
        {
            var items = context.RecursosHumanos
                              .AsNoTracking()
                              .Where(i => i.id_recursos == idRecursos);

            items = items.Include(i => i.Laboratorio);

            items = items.Include(i => i.Recurso);

            var item = items.FirstOrDefault();

            OnRecursosHumanoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.RecursosHumano> CancelRecursosHumanoChanges(Models.C4G.RecursosHumano item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnRecursosHumanoUpdated(Models.C4G.RecursosHumano item);

        public async Task<Models.C4G.RecursosHumano> UpdateRecursosHumano(int? idRecursos, Models.C4G.RecursosHumano recursosHumano)
        {
            OnRecursosHumanoUpdated(recursosHumano);

            var item = context.RecursosHumanos
                              .Where(i => i.id_recursos == idRecursos)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(recursosHumano);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return recursosHumano;
        }

        partial void OnServicoDeleted(Models.C4G.Servico item);

        public async Task<Models.C4G.Servico> DeleteServico(int? idServico)
        {
            var item = context.Servicos
                              .Where(i => i.id_servico == idServico)
                              .Include(i => i.Atribuicaos)
                              .Include(i => i.Pedidos)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnServicoDeleted(item);

            context.Servicos.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnServicoGet(Models.C4G.Servico item);

        public async Task<Models.C4G.Servico> GetServicoByidServico(int? idServico)
        {
            var items = context.Servicos
                              .AsNoTracking()
                              .Where(i => i.id_servico == idServico);

            items = items.Include(i => i.Pessoa);

            var item = items.FirstOrDefault();

            OnServicoGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.C4G.Servico> CancelServicoChanges(Models.C4G.Servico item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnServicoUpdated(Models.C4G.Servico item);

        public async Task<Models.C4G.Servico> UpdateServico(int? idServico, Models.C4G.Servico servico)
        {
            OnServicoUpdated(servico);

            var item = context.Servicos
                              .Where(i => i.id_servico == idServico)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(servico);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return servico;
        }
    }
}
