using Disparo.Plataforma.Domain.Answerables;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o receptor de uma e-mail..</summary>
    public class EmailReceiver
    {
        /// <summary>Endereço de e-mail.</summary>
        public string Address { get; set; }
    
        /// <summary>Nome do proprietário da conta.</summary>
        public Answerable Answerable { get; set; }

        /// <summary>Contrutor com parâmetros para instanciação do objeto.</summary>
        /// <param name="address">Endereço de e-mail.</param>
        /// <param name="answerable">Nome do proprietário da conta.</param>
        public EmailReceiver(string address, Answerable answerable)
        {
            Address = address;
            Answerable = answerable;
        }
    }
}