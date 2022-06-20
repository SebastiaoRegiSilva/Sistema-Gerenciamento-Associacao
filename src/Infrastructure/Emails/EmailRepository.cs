using Hort.Etec.Apm.Domain.Emails;

namespace Hort.Etec.Apm.Infra.Emails
{
    /// <summary>Implementação do repositório de emails para o Mongo DB.</summary>
    public class EmailRepository : IEmailRepository
    {
        /// <summary>Contexto utilizado pelo repositório de emails para acessar a coleção de um email na base de dados.</summary>
        private readonly EmailContext _ctxEmail;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public EmailRepository(string conString, string database)
        {
            _ctxEmail = new EmailContext(conString, database);
        }
    }
}