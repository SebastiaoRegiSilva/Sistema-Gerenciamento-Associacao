namespace Disparo.Plataforma.Domain.NumerosTelefones
{
    /// <summary>Entidade que representa os números de telefone.</summary>
    public class NumeroTelefone
    {
        /// <summary>Discagem Direta à Distância.</summary>
        public int Ddd { get; set; }

        /// <summary>Número do telefone.<summary>
        public int Numero { get; set; }
    
        /// Construtor com parâmetros para instanciação de um número de telefone.
        /// </summary>
        /// <param name="ddd">Discagem Direta á Distância.</param>
        /// <param name="numero">Número de telefone.</param>
        public NumeroTelefone(int ddd, int numero)
        {
            Ddd = ddd;
            Numero = numero;
        }
    }
}