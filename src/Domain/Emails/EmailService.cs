using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hort.Etec.Apm.Domain.Emails
{
    /// <summary>Serviço que provê acesso aos dados dos emails.</summary>
    public class EmailService
    {
        /// <summary>Repositório para armazenamento dos responsáveis.</summary>
        private readonly IEmailRepository _emailRep;

        /// <summary>Construtor com injeção de dependência.</summary>
        /// <param name="responsavelRep">Repositório para armazenamento dos emails.</param>
        public EmailService(IEmailRepository emailRep)
        {
            _emailRep = emailRep;
        }

        // /// <summary>Regular Expressions utilizada para validação de e-mails.</summary>
        // private readonly Regex _emailRegex;

        // /// <summary>Construtor com injeção de dependência.</summary>
        // public EmailService()
        // {
        //     _emailRegex = new Regex(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$");
        // }

        /// <summary>Validar se o formato do endereço de e-mail está correto.</summary>
        /// <param name="email">Endereço de e-mail a ser validado.</param>
        public async Task<bool> ValidarEmailAsync(string email)
        {
            var emailRegex = new Regex(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$");

            await Task.Yield();

            return emailRegex.IsMatch(email);
        }
    }
}