using System.Threading.Tasks;

namespace Domain.Plataforma.Domain.Predios
{
    /// <summary>Interface que padroniza o repositório dos prédios.</summary>
    public interface IPredioRepository
    {
        /// <summary>Cadastra no repositório um novo prédio no sistema.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        Task<string> CadastrarPredioAsync(int numeroIdentificador);
        
        /// <summary>Recuperar no repositório um prédio com base no número identificador.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        /// <returns>Prédio recuperado.</returns>
        Task<Predio> RecuperarPredioPorNumeroAsync(string numeroIdentificador);
        
        /// <summary>Edita no repositório um prédio com base no número identificador.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        Task EditarPredioAsync(string numeroIdentificador);
        
        /// <summary>Exclui no repositório um prédio cadastrado no sistema com base no número identificador.</summary>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        Task ExcluirPredioAsync(string numeroIdentificador);
    }
}