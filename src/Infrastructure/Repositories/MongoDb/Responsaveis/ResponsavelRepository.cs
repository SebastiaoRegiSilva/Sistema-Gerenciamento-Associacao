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
    }
}