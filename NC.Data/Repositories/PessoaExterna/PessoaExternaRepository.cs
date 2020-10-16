using Microsoft.EntityFrameworkCore;
using NC.Domain.Entities;
using NC.Domain.Queries;
using NC.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NC.Data.Repositories
{
    public class PessoaExternaRepository : IPessoaExternaRepository
    {
        private readonly Context.NCContext _context;
        //private DbSet<NcPessoaExterna> _dataset;
        public PessoaExternaRepository(Context.NCContext context)
        {
            _context = context;
        }

        //*******************************************************************************
        //Inserir
        public NcPessoaExterna Inserir(NcPessoaExterna item)
        {
            try
            {
                _context.NcPessoaExterna.Add(item);
                _context.SaveChanges();         // é aqui que vai ao banco e faz a persistencia

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;

        }

        //*******************************************************************************
        //Alterar
        public NcPessoaExterna Alterar(NcPessoaExterna item)
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

        //*******************************************************************************
        //Excluir
        public bool Excluir(NcPessoaExterna item)
        {
            try
            {
                _context.NcPessoaExterna.Remove(item);
                _context.SaveChangesAsync();      //Nessa linha ele vai no context e posteriormente deleta o regitro no banco
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //*******************************************************************************
        //Obter

        public IQueryable<NcPessoaExterna> ObterTodos()
        {
            return _context.NcPessoaExterna
              .AsNoTracking()
              //.Include(x => x.Empresa)
              //.Include(x => x.vis)
              //.Include(x => x.Veiculos)
              //.Include(x => x.Vagas)
              //.Include(x => x.Abordagem)
              .Where(PessoaExternaQueries.ObterTodos());            
        }
        
        public NcPessoaExterna ObterPorId(int id)
        {
            return _context
                .NcPessoaExterna
                .FirstOrDefault(x => x.Id == id);           //FirstOrDefault traz o primeiro ou nulo
        }

        public IEnumerable<NcPessoaExterna> ObterPorUnidade(string unidade)
        {
            return _context.NcPessoaExterna
              .AsNoTracking()
              .Where(PessoaExternaQueries.ObterPorUnidade(unidade))
              .OrderBy(x => x.Nome);
        }


        public NcPessoaExterna ObterPorNome(string nome)
        {
            return _context
               .NcPessoaExterna
               .FirstOrDefault(x => x.Nome == nome);           //FirstOrDefault traz o primeiro ou nulo
        }

        public NcPessoaExterna ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorDocumento(string documentoNumero)
        {
            throw new NotImplementedException();
        }

        public NcPessoaExterna ObterPorDocumentoTipo(string documentoNumero, string tipo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterPorPeriodo(string documentoNumero, DateTime data, bool ativo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NcPessoaExterna> ObterTodosInativos()
        {
            throw new NotImplementedException();
        }
    }
}
