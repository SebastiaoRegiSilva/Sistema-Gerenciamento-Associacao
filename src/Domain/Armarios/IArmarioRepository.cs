using Hort.Etec.Apm.Domain.Predios;
using System.Threading.Tasks;

namespace Hort.Etec.Apm.Domain.Armarios
{
    /// <summary>Interface que padroniza o repositório dos armários.</summary>
    public interface IArmarioRepository
    {
        /// <summary>Cadastra no repositório um novo armário.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        /// <param name="Predio">Prédio onde está localizado.</param>
        /// <param name="anoValidade">Ano vigente com permisssão de uso do armário.</param>
        Task<string> CadastrarArmarioAsync(int numeroIdentificador, Predio Predio, int anoValidade);

        /// <summary>Edita no repositório um armário cadastrado.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        Task EditarArmarioAsync(int numeroIdentificador);

        /// <summary>Recupera no repositório um armário cadastrado com base no número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        Task<Armario> RecuperarArmarioNumeroIdentificadorAsync(int numeroIdentificador);

        /// <summary>Recupera no repositório um armário cadastrado com base no nome do aluno.</summary>
        /// <param name="nomeAluno">Nome do aluno responsável pelo armário.</param>
        // Task<Armario>RecuperarArmarioAlunoAsync(int  nomeAluno);

        /// <summary>Exclui no repositório um armário cadastrado no sistema com base no seu número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        Task ExcluirArmarioAsync(int numeroIdentificador);
    }
}