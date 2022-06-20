using Hort.Etec.Apm.Infra.Predios.Models;
using MongoDB.Driver;

namespace Hort.Etec.Apm.Infra.Predios
{
    /// <summary>Contexto utilizado para acesso aos dados dos prédios.</summary>
    class PredioContext
    {
        // <summary>Base de dados MongoDB onde estão armazenados os prédios.</summary>
        private readonly IMongoDatabase _database;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados MongoDB.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public PredioContext(string conString, string database)
        {
            var client = new MongoClient(conString);
            if (client != null)
                _database = client.GetDatabase(database);

            BsonMapConfig.Config();
        }

        /// <summary>Coleção de prédios.</summary>
        public IMongoCollection<PredioModel> Predios
        {
            get
            {
                return _database.GetCollection<PredioModel>("Predios");
            }
        }
    }
}