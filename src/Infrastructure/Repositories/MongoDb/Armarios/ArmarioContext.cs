using Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Armarios.Models;
using MongoDB.Driver;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Armarios
{
    /// <summary>Contexto utilizado para acesso aos dados dos armários.</summary>
    class ArmarioContext
    {
        /// <summary>Base de dados MongoDB onde estão armazenados os armários.</summary>
        private readonly IMongoDatabase _database = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados MongoDB.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public ArmarioContext(string conString, string database)
        {
            var client = new MongoClient(conString);
            if (client != null)
                _database = client.GetDatabase(database);

            BsonMapConfig.Config();
        }

        /// <summary>Coleção de armários.</summary>
        public IMongoCollection<ArmarioModel> Armarios
        {
            get
            {
                return _database.GetCollection<ArmarioModel>("Armarios");
            }
        }
    }
}