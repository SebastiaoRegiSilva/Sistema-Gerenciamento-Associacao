namespace Domain.Plataforma.Domain.Buildings
{
    /// <summary>Objeto de valor que representa o endereço de um prédio na ETEC. </summary>
    public class Building
    {
        /// <summary>Número de identificação do prédio.</summary>
        public int NumberIdentificator { get; set; }

        /// <summary>Construtor para instanciação de um prédio e acesso a suas informações.</summary>
        /// <param name="numberIdentificator">Número de identificação do prédio.</param>
        public Building(int numberIdentificator)
        {
            NumberIdentificator = numberIdentificator;

        }
    }
}