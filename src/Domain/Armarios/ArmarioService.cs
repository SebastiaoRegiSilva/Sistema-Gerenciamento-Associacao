using Hort.Etec.Apm.Domain.Alunos;
using Hort.Etec.Apm.Domain.Predios;
using System.Threading.Tasks;

namespace Hort.Etec.Apm.Domain.Armarios
{
    /// <summary>Serviço que provê acesso aos dados dos armários.</summary>
    public class ArmarioService
    {

        /// <summary>Serviço que provê acesso aos dados e operações de alunos.</summary>
        private readonly AlunoService _alunoService;

        /// <summary>Repositório para armazenamento dos armários.</summary>
        private readonly IArmarioRepository _armarioRep;

        /// <summary>Serviço que provê acesso aos dados e operaçãoes de prédios.</summary>
        private readonly PredioService _predioService;

        /// <summary>Construtor com injeção de dependência.</summary>
        /// <param name="armarioRep">Repositório para armazenamento dos armários.</param>
        /// <param name="alunoService">Serviço que provê acesso aos dados e operaçãoes de alunos.</param>
        /// <param name="predioService">Serviço que provê acesso aos dados e operaçãoes de prédios.</param>
        public ArmarioService(IArmarioRepository armarioRep, AlunoService alunoService, PredioService predioService)
        {
            _armarioRep = armarioRep;
            _alunoService = alunoService;
            _predioService = predioService;
        }

        /// <summary>Cadastra no repositório um novo armário.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        /// <param name="numeroPredio">Prédio onde está localizado.</param>
        /// <param name="anoValidade">Ano vigente com permisssão de uso do armário.</param>
        /// <returns>Código de identificação gerado para um armário cadastrado.</returns>
        public async Task<string> CadastrarArmarioAsync(int numeroPredio, int numeroIdentificador, int anoValidade)
        {
            var predioRecuperado = await _predioService.RecuperarPredioPorNumeroAsync(numeroPredio);

            var idArmario = await _armarioRep.CadastrarArmarioAsync(numeroIdentificador, predioRecuperado, anoValidade);

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
        public async Task<Armario> RecuperarArmarioNumeroIdentificadorAsync(int numeroIdentificador)
        {
            return await _armarioRep.RecuperarArmarioNumeroIdentificadorAsync(numeroIdentificador);
        }

        /// <summary>Recupera no repositório um armário cadastrado com base no nome do aluno.</summary>
        /// <param name="nomeAluno">Nome do aluno responsável pelo armário.</param>
        //Task<Armario>RecuperarArmarioAlunoAsync(int  nomeAluno){}

        /// <summary>Exclui no repositório um armário cadastrado no sistema com base no seu número.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        public async Task ExcluirArmarioAsync(int numeroIdentificador)
        {
            await _armarioRep.ExcluirArmarioAsync(numeroIdentificador);
        }
    }
}