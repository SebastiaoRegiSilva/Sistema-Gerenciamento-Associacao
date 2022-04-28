using System.Threading.Tasks;

namespace Domain.Plataforma.Domain.Predios
{
    /// <summary>Interface que padroniza o repositório dos prédios.</summary>
    public interface IPredioRepository
    {
        /// <summary>Cadastra na base de dados um novo prédio no sistema.</summary>
        /// <param name="id">Código de identificação do prédio.</param>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        Task<string> CadastrarPredioAsync(string id, int numeroIdentificador);
        
        /// <summary>Recuperar no repositório um prédio com base no número identificador.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        /// <returns>Prédio recuperado.</returns>
        Task<Predio> RecuperarPredioPorNumeroAsync(string numeroIdentificador);
        
        /// <summary>Edita na base de dados um prédio com base no número identificador.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        Task EditarClasseAsync(string numeroIdentificador);
        
        /// <summary>Exclui na base de dados um prédio cadastrado no sistema com base no número identificador.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        Task ExcluirPredioAsync(string numeroIdentificador);
    }
}