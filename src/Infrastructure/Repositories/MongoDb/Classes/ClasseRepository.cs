using Disparo.Plataforma.Domain.Classes;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Classes
{
    public class ClasseRepository : IClasseRepository
    {
        /// <summary>Contexto utilizado pelo repositório de classes para acessar a coleção de um classe na base de dados.</summary> 
        private readonly ClasseContext _ctxClasse = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public ClasseRepository(string conString, string database)
        {
            _ctxClasse = new ClasseContext(conString, database);
        }
    }
}