using Disparo.Plataforma.Domain.Alunos;
using Domain.Plataforma.Domain.Predios;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Domain.Armarios
{
    /// <summary>Interface que padroniza o repositório dos armários.</summary>
    public interface IArmarioRepository
    {
        /// <summary>Cadastra no repositório um novo armário.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        /// <param name="predio">Prédio onde está localizado.</param>
        /// <param name="aluno">Estudante responsável pelo armário.</param>
        /// <param name="anoValidade">Ano vigente com permisssão de uso do armário.</param>
        Task<string>CadastrarArmarioAsync(string numeroIdentificador, Predio predio, Aluno aluno, int anoValidade);
        
        /// <summary>Edita no repositório um armario cadastrado.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        Task<Armario>EditarArmarioAsync(string matricula);
        
        /// <summary>Recupera no repositório um armario cadastrado com base no número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        Task<Armario>RecuperarArmarioNumeroIdentificadorAsync(string numeroIdentificador);

        /// <summary>Recupera no repositório um armário cadastrado com base no nome do aluno.</summary>
        /// <param name="nomeAluno">Nome do aluno responsável pelo armário.</param>
        Task<Armario>RecuperarArmarioAlunoAsync(string nomeAluno);

        /// <summary>Exclui no repositório um armário cadastrado no sistema com base no seu número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        Task ExcluirArmarioAsync(string numeroIdentificador);

    }
}