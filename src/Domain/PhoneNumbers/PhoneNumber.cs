namespace Disparo.Plataforma.Domain.PhoneNumbers
{
    /// <summary>Entidade que representa os números de telefone</summary>
    public class PhoneNumber
    {
        /// <summary>Discagem Direta à Distância.</summary>
        public int Ddd { get; set; }

        /// <summary>Número do telefone.<summary>
        public int Number { get; set; }
    
        /// <summary>Tipo do telefone.</summary>
        public enum TypePhoneNumber { get, }
    }
}