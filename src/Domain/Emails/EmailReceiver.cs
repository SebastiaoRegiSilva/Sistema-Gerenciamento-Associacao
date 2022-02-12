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
    
        // /// <summary>Validar se o email tem o formato correto.</summary>
        // static void ValidarEmail(string address)
        // {
        //     if(string.IsNullOrEmpty(address))
        //         return;

        //     if(!_emailRegex.IsMatch(address))
        //         throw new AddressEmailInvalidException(address);
        // }
    }
}