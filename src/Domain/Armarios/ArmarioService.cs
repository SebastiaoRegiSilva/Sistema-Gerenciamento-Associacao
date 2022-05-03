using Disparo.Plataforma.Domain.Alunos;
using Domain.Plataforma.Domain.Predios;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Domain.Armarios
{
    /// <summary>Serviço que provê acesso aos dados dos armários.</summary>
    public class ArmarioService
    {
        /// <summary>Repositório para armazenamento dos armários.</summary>
        private readonly IArmarioRepository _armarioRep;
        
        /// <summary>Construtor com injeção de dependência.</summary>
        /// <param name="armarioRep">Repositório para armazenamento dos armários.</param>
        public ArmarioService(IArmarioRepository armarioRep)
        {
            _armarioRep = armarioRep;
        }
        
        /// <summary>Cadastra no repositório um novo armário.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        /// <param name="predio">Prédio onde está localizado.</param>
        /// <param name="aluno">Estudante responsável pelo armário.</param>
        /// <param name="anoValidade">Ano vigente com permisssão de uso do armário.</param>
        /// <returns>Código de identificação gerado para um armário cadastrado.</returns>
        public async Task<string>CadastrarArmarioAsync(int numeroIdentificador, Predio predio, Aluno aluno, int anoValidade)
        {
            var idArmario = await _armarioRep.CadastrarArmarioAsync(numeroIdentificador, predio, aluno, anoValidade);

            return idArmario;
        }
        
        /// <summary>Edita no repositório um armário cadastrado.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        public async Task EditarArmarioAsync(int numeroIdentificador)
        {
            await _armarioRep.EditarArmarioAsync(numeroIdentificador);
        }
        
        /// <summary>Recupera no repositório um armário cadastrado com base no número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        public async Task<Armario>RecuperarArmarioNumeroIdentificadorAsync(int  numeroIdentificador)
        {
            return await _armarioRep.RecuperarArmarioNumeroIdentificadorAsync(numeroIdentificador);
        }

        /// <summary>Recupera no repositório um armário cadastrado com base no nome do aluno.</summary>
        /// <param name="nomeAluno">Nome do aluno responsável pelo armário.</param>
        //Task<Armario>RecuperarArmarioAlunoAsync(int  nomeAluno){}
        
        /// <summary>Exclui no repositório um armário cadastrado no sistema com base no seu número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        public async Task ExcluirArmarioAsync(int  numeroIdentificador)
        {
            await _armarioRep.ExcluirArmarioAsync(numeroIdentificador);
        }
    }
}