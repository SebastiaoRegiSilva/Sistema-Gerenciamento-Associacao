using System.Threading.Tasks;

namespace Disparo.Plataforma.Domain.Classes
{
    /// <summary>Interface que padroniza o repositório das classes.</summary>
    public interface IClasseRepository
    {
        /// <summary>Cadastra na base de dados uma nova classe no sistema.</summary>
        /// <param name="id">Código de identificação da classe.</param>
        /// <param name="habilitacao">Nome do curso em que o aluno está matriculado.</param>
        /// <param name="anoOC">Ano vigente.</param>
        /// <param name="moduloSerie">Módulo e série vigentes.</param>
        /// <returns>Código de identificação gerado para uma classe cadastrada.</returns>
        Task<string> CadastrarClasseAsync(string id, string habilitacao, int anoOC, string moduloSerie);
        
        /// <summary>Recuperar no repositório uma classe com base no seu código de identificação.</summary>
        /// <param name="habilitacao">Nome do curso em que o aluno está matriculado.</param>
        /// <returns>Classe recuperado.</returns>
        Task<Classe> RecuperarClassePorHabilitacaoAsync(string habilitacao);
        
        /// <summary>Edita na base de dados uma classe com base no nome da matéria.</summary>
        /// <param name="id">Código de identificação da classe.</param>
        Task EditarClasseAsync(string habilitacao);
        
        /// <summary>Exclui na base de dados uma classe cadastrada no sistema com base no nome da habilitação.</summary>
        /// <param name="habilitacao">Nome do curso em que o aluno está matriculado.</param>
        Task ExcluirClasseAsync(string habilitacao);
    }
}