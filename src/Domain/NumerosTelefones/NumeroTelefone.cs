namespace Disparo.Plataforma.Domain.NumerosTelefones
{
    /// <summary>Entidade que representa os números de telefone</summary>
    public class NumeroTelefone
    {
        /// <summary>Discagem Direta à Distância.</summary>
        public int Ddd { get; set; }

        /// <summary>Número do telefone.<summary>
        public int numeroTelefone { get; set; }
    
        /// <summary>Tipo do telefone.</summary>
        public enum TipoNumeroTelefone { get, }
    }
}