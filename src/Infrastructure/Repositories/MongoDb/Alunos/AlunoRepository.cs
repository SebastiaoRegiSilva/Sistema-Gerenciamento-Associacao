using Disparo.Plataforma.Domain.Alunos;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Alunos
{
    public class AlunoRepository : IAlunoRepository
    {
        /// <summary>Contexto utilizado pelo repositório de alunos para acessar a coleção de um aluno na base de dados.</summary> 
        private readonly AlunoContext _ctxAluno = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public AlunoRepository(string conString, string database)
        {
            _ctxAluno = new AlunoContext(conString, database);
        }
    }
}