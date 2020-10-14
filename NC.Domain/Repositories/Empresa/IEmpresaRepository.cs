﻿using NC.Domain.Entities;
using System.Linq;

namespace NC.Domain.Repositories.Entidade
{
    public interface IEmpresaRepository
    {
        //Inserir
        NcEmpresa Inserir(NcEmpresa item);

        //Alterar
        NcEmpresa Alterar(NcEmpresa item);

        //Excluir
        bool Excluir(NcEmpresa item);


        //Get

        IQueryable<NcEmpresa> ObterTodos();

        NcEmpresa ObterPorId(int id);

        NcEmpresa ObterPorNome(string nome);
    }
}

