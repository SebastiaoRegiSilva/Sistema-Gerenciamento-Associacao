using Disparo.Plataforma.Domain.Armarios;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Armarios
{
    public class ArmarioRepository : IArmarioRepository
    {
        /// <summary>Contexto utilizado pelo repositório de armários para acessar a coleção de um armário na base de dados.</summary> 
        private readonly ArmarioContext _ctxArmario = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public ArmarioRepository(string conString, string database)
        {
            _ctxArmario = new ArmarioContext(conString, database);
        }
    }
}