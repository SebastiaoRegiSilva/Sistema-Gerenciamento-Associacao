using System.Collections.Generic;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o e-mail de quem está enviando um conteúdo/mensagem.</summary>
    public class EmailSender
    {
        /// <summary>Endereço de quem está enviando.</summary>
        public string Address { get; set; }

        /// <summary>Nome do proprietário da conta.</summary>
        public string OwnerName { get; set; }
        
        /// <summary> Título do email.</summary>
        public string Title { get; set; }
        
        /// <summary>Corpo do e-mail.</summary>
        public  BodyEmailSender BodyEmail { get; set; }

        /// <summary>Receptores do e-mail.</summary>
        public IEnumerable<EmailReceiver> Receivers { get; set; }
    }
}