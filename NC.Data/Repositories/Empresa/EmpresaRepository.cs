using Microsoft.EntityFrameworkCore;
using NC.Domain.Entities;
using NC.Domain.Queries.Entidade;
using NC.Domain.Repositories.Entidade;
using System;
using System.Linq;

namespace NC.Data.Repositories.Entidade
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly Context.NCContext _context;

        public EmpresaRepository(Context.NCContext context)
        {
            _context = context;
        }

        public NcEmpresa Alterar(NcEmpresa item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;   // O EF verifica qual campo foi alterado e faz o update somente nesse campo
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public bool Excluir(NcEmpresa item)
        {
            try
            {
                //foreach (var item2 in item.EmpresaSite)
                //{
                //    if (item2.SiteId > 0 && item2.EmpresaId > 0)
                //        _context.NcEmpresaSite.Remove(item2);
                //}

                _context.NcEmpresa.Remove(item);
                _context.SaveChangesAsync();      //Nessa linha ele vai no context e posteriormente deleta o regitro no banco
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NcEmpresa Inserir(NcEmpresa item)
        {
            try
            {               
                _context.NcEmpresa.Add(item);
                _context.SaveChanges();                 // é aqui que vai ao banco e faz a persistencia

                int id = item.Id; // Yes it's here
            
                //foreach (var item2 in item.EmpresaSite)
                //{
                //    item2.EmpresaId = id;

                //    if (item2.SiteId > 0)
                //        _context.NcEmpresaSite.Add(item2);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public NcEmpresa ObterPorId(int id)
        {
            return _context
               .NcEmpresa
               .FirstOrDefault(x => x.Id == id);           //FirstOrDefault traz o primeiro ou nulo
        }

        public IQueryable<NcEmpresa> ObterTodos()
        {
            return _context
                .NcEmpresa
                //.Include(x => x.EmpresaSite)
                //.ThenInclude(x => x.Site)
                .AsNoTracking()
                .Where(EmpresaQueries.ObterTodos());
        }

        public NcEmpresa ObterPorNome(string nome)
        {
            return _context
               .NcEmpresa
               .FirstOrDefault(x => x.Nome == nome);           //FirstOrDefault traz o primeiro ou nulo
        }
    }
}




