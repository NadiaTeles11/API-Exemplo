using NC.Domain.Entities.UsuarioAbordagem;
using System.Linq;

namespace NC.Domain.Repositories.UsuarioAbordagem
{
    public interface IUsuarioAbordagemRepository
    {
        //Inserir
        NcUsuarioAbordagem Inserir(NcUsuarioAbordagem item);

        //Alterar
        NcUsuarioAbordagem Alterar(NcUsuarioAbordagem item);

        //Excluir
        bool Excluir(NcUsuarioAbordagem item);


        //Get

        IQueryable<NcUsuarioAbordagem> ObterTodos();

        NcUsuarioAbordagem ObterPorId(int id);

        //NcUsuarioAbordagem ObterPorUsuarioTipo(int usuarioTipo, int usuarioId);

    }
}

