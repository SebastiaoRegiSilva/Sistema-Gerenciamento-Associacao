using Disparo.Plataforma.Domain.Responsaveis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Responsaveis
{
    /// <summary>Implementação do repositório de responsáveis para o Mongo DB.</summary>
    public class ResponsavelRepository : IResponsavelRepository
    {
        Task<string> IResponsavelRepository.CadastrarResponsavelAsync(string id, string cpf, string nome, string enderecoEmail, IEnumerable<string> numerosTelefones)
        {
            throw new NotImplementedException();
        }

        Task IResponsavelRepository.EditarClasseAsync(string cpf)
        {
            throw new NotImplementedException();
        }

        Task IResponsavelRepository.ExcluirResponsavelAsync(string cpf)
        {
            throw new NotImplementedException();
        }

        Task<Responsavel> IResponsavelRepository.RecuperarResponsavelPorCPFAsync(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}