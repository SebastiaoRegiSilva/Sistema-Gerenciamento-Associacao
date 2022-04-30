using System.Threading.Tasks;
using Domain.Plataforma.Domain.Predios;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Predios
{
    public class PredioRepository : IPredioRepository
    {
        /// <summary>Contexto utilizado pelo repositório de prédios para acessar a coleção de um prédio na base de dados.</summary> 
        private readonly PredioContext _ctxPredio = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public PredioRepository(string conString, string database)
        {
            _ctxPredio = new PredioContext(conString, database);
        }

        public async Task<string> CadastrarPredioAsync(string id, int numeroIdentificador)
        {
            
        }

        public async Task EditarClasseAsync(string numeroIdentificador)
        {
            
        }

        public async Task ExcluirPredioAsync(string numeroIdentificador)
        {
            
        }

        public async Task<Predio> RecuperarPredioPorNumeroAsync(string numeroIdentificador)
        {
            
        }
    }
}