using Microsoft.EntityFrameworkCore;
using NexcodeControls.Domain.Entities.UsuarioAbordagem;
using NexcodeControls.Domain.Queries.UsuarioAbordagem;
using NexcodeControls.Domain.Repositories.UsuarioAbordagem;
using System;
using System.Linq;

namespace NexcodeControls.Data.Repositories.UsuarioAbordagem
{
    public class UsuarioAbordagemRepository : IUsuarioAbordagemRepository
    {
        private readonly Context.NexcodeControlsContext _context;

        public UsuarioAbordagemRepository(Context.NexcodeControlsContext context)
        {
            _context = context;
        }

        public NcUsuarioAbordagem Alterar(NcUsuarioAbordagem item)
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

        public bool Excluir(NcUsuarioAbordagem item)
        {
            try
            {
                _context.NcUsuarioAbordagem.Remove(item);
                _context.SaveChangesAsync();      //Nessa linha ele vai no context e posteriormente deleta o regitro no banco
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public NcUsuarioAbordagem Inserir(NcUsuarioAbordagem item)
        {
            try
            {
                _context.NcUsuarioAbordagem.Add(item);
                _context.SaveChanges();                 // é aqui que vai ao banco e faz a persistencia

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public NcUsuarioAbordagem ObterPorId(int id)
        {
            return _context
               .NcUsuarioAbordagem
               .FirstOrDefault(x => x.Id == id);           //FirstOrDefault traz o primeiro ou nulo
        }

        public IQueryable<NcUsuarioAbordagem> ObterTodos()
        {
            return _context.NcUsuarioAbordagem
             .AsNoTracking()
             .Where(UsuarioAbordagemQueries.ObterTodos());
        }

        //public NcUsuarioAbordagem ObterPorUsuarioTipo(int usuarioTipo, int usuarioId)
        //{
        //    return _context
        //        .NcUsuarioAbordagem
        //        .FirstOrDefault(x => x.UsuarioTipo == usuarioTipo && x.UsuarioId == usuarioId);
        //}
    }
}



