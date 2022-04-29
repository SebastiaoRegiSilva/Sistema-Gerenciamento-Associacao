namespace Domain.Plataforma.Domain.Predios
{
    /// <summary>Objeto de valor que representa o endereço de um prédio na ETEC. </summary>
    public class Predio
    {
        /// <summary>Código de identificação do prédio.</summary>
        public string Id { get; set; }
        
        /// <summary>Número de identificação do prédio.</summary>
        public int NumeroIdentificador { get; set; }

        /// <summary>Construtor para instanciação de um prédio e acesso a suas informações.</summary>
        /// <param name="id">Código de identificação do prédio.</param>
        /// <param name="numeroIdentificador">Número de identificação do prédio.</param>
        public Predio(string id, int numeroIdentificador)
        {
            Id = id;
            NumeroIdentificador = numeroIdentificador;
        }
    }
}