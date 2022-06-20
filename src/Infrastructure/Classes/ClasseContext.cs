using Hort.Etec.Apm.Infra.Classes.Models;
using MongoDB.Driver;

namespace Hort.Etec.Apm.Infra.Classes
{
    /// <summary>Contexto utilizado para acesso aos dados das classes.</summary>
    class ClasseContext
    {
        /// <summary>Base de dados MongoDB onde estão armazenados os classes.</summary>
        private readonly IMongoDatabase _database;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados MongoDB.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public ClasseContext(string conString, string database)
        {
            var client = new MongoClient(conString);
            if (client != null)
                _database = client.GetDatabase(database);

            BsonMapConfig.Config();
        }

        /// <summary>Coleção de classes.</summary>
        public IMongoCollection<ClasseModel> Classes
        {
            get
            {
                return _database.GetCollection<ClasseModel>("Classes");
            }
        }
    }
}