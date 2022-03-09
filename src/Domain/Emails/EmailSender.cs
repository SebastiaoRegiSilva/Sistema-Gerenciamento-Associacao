using System.Collections.Generic;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o e-mail de quem está enviando um conteúdo/mensagem.</summary>
    public class EmailSender
    {
        /// Senha e email de acesso a conta, provisório.
        
        /// <summary>Endereço de quem está enviando.</summary>
        public string Address { get; set; }

        /// <summary>Senha de acesso ao e-mail.</summary>
        public string Password { get; set; }
        
        /// <summary>Nome do proprietário da conta.</summary>
        public string OwnerName { get; set; }

        /// <summary> Título do email.</summary>
        public string Subject { get; set; }

        /// <summary>Corpo do e-mail.</summary>
        public string BodyEmail { get; set; }

        /// <summary>Receptores do e-mail.</summary>
        public IEnumerable<EmailReceiverParent> Receivers { get; set; }
        
        /// <summary>Endereço de e-mail do estudante.</summary>
        public EmailReceiverStudent ReceiverStudent { get; set; }

        /// <summary>Construtor para instanciação de um email que será enviado. </summary>
        /// <param name="address">Endereço de quem está enviando.</param>
        /// <param name="passsword">Senha de acesso ao e-mail.</param>
        /// <param name="ownerName">Nome do proprietário da conta que está enviando o e-mail.</param>
        /// <param name="subject">Título do e-mail.</param>
        /// <param name= "bodyEmail">Corpo do e-mail.</param>
        /// <param name= "receivers">Receptores do e-mail.</param>
        public EmailSender(string address, string passaword, string ownerName, string subject, string bodyEmail, IEnumerable<EmailReceiverParent> receivers)
        {
            Address = address;
            Password = passaword;
            OwnerName = ownerName;
            Subject = subject;
            BodyEmail = bodyEmail;
            Receivers = receivers;
        }

        /// <summary>Construtor para instanciação de um email que será enviado. </summary>
        /// <param name="address">Endereço de quem está enviando.</param>
        /// <param name="passsword">Senha de acesso ao e-mail.</param>
        /// <param name="ownerName">Nome do proprietário da conta que está enviando o e-mail.</param>
        /// <param name="subject">Título do e-mail.</param>
        /// <param name= "bodyEmail">Corpo do e-mail.</param>
        /// <param name= "receiverStudent">Endereço de e-mail do estudante.</param>
        public EmailSender(string address, string passaword, string ownerName, string subject, string bodyEmail, EmailReceiverStudent receiverStudent)
        {
            Address = address;
            Password = passaword;
            OwnerName = ownerName;
            Subject = subject;
            BodyEmail = bodyEmail;
            ReceiverStudent = receiverStudent;
        }
    }
}