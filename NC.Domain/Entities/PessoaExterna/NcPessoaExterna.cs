
using System;
using System.Collections.Generic;

namespace NC.Domain.Entities
{
    public partial class NcPessoaExterna : BaseEntity
    {

        #region Propriedades privadas
        private string _nome;
        private string _grupo;
        private string _telefoneFixo;
      
        #endregion

        #region Construtores

        public NcPessoaExterna() { }

        public NcPessoaExterna(string nome, string grupo, string telefoneFixo )
        {           
            Nome = nome;
            Grupo = grupo;
            TelefoneFixo = telefoneFixo;            
        }

      

        #endregion

        #region Propriedades       
        public string Nome { get => _nome; private set => _nome = value.ToUpper(); }
        public string Grupo { get => _grupo; private set => _grupo = value.ToUpper(); }
        public string TelefoneFixo { get => _telefoneFixo; private set => _telefoneFixo = value.ToUpper(); }
        
        #endregion

        #region Metodos

        public void Alterar( string nome, string grupo, string telefoneFixo )
        {            
            Nome = nome;
            Grupo = grupo;
            TelefoneFixo = telefoneFixo;           
        }


        #endregion
    }
}
