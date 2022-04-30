using Disparo.Plataforma.Domain.Responsaveis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Responsaveis
{
    /// <summary>Implementação do repositório de responsáveis para o Mongo DB.</summary>
    public class ResponsavelRepository : IResponsavelRepository
    {
        /// <summary>Contexto utilizado pelo repositório de responsáveis para acessar a coleção de um responsável na base de dados.</summary> 
        private readonly ResponsavelContext _ctxResponsavel = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public ResponsavelRepository(string conString, string database)
        {
            _ctxResponsavel = new ResponsavelContext(conString, database);
        }

        /// <summary>Cadastra no base de dados um novo responsável no sistema.</summary>
        /// <param name= "id">Código de identificação do responsável.</param>
        /// <param name="cpf">Cadastro de pessoa físíca do responsável do aluno.</param>
        /// <param name="nome">Nome dos pais ou responsáveis.</param>
        /// <param name="enderecoEmail">Endereço de e-mail cdos pais ou responsáveis.</param>
        /// <param name="numerosTelefones">Números para comunicação direta com o aluno.</param>
        /// <returns>Código de identificação gerado para um responsável cadastrado.</returns>
        public async Task<string> IResponsavelRepository.CadastrarResponsavelAsync(string id, string cpf, string nome, string enderecoEmail, IEnumerable<string> numerosTelefones)
        {
            throw new NotImplementedException();
        }

        /// <summary>Edita na base de dados um responsável com base no CPF.</summary>
        /// <param name="cpf">Cadastro de pessoa física do responsável do aluno.</param>
        public async Task IResponsavelRepository.EditarClasseAsync(string cpf)
        {
            throw new NotImplementedException();
        }

        /// <summary>Exclui na base de dados um responsável cadastrado no sistema com base no CPF.</summary>
        /// <param name="cpf">Cadastro de pessoa física do responsável do aluno.</param>
        public async Task IResponsavelRepository.ExcluirResponsavelAsync(string cpf)
        {
            throw new NotImplementedException();
        }

        /// <summary>Recuperar na base de dados um responsável com base no CPF.</summary>
        /// <param name="cpf">Cadastro de pessoa física do responsável do aluno.</param>
        public async Task<Responsavel> IResponsavelRepository.RecuperarResponsavelPorCPFAsync(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}