using System.Text.RegularExpressions;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Serviço responsável por operações com emails.</summary>
    public class EmailService
    {
        /// <summary>Regular Expressions utilizada para validação de e-mails.</summary>
        private readonly Regex _emailRegex;

        /// <summary>Construtor com injeção de dependência.</summary>
        public EmailService()
        {
            _emailRegex = new Regex(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$");
        }
    }
}