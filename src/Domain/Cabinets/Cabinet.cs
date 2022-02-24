using Disparo.Plataforma.Domain.Students;
using Domain.Plataforma.Domain.Buildings;

namespace Disparo.Plataforma.Domain.Cabinet
{
    /// <summary>Objeto de valor que representa um armário para guarda de objetos pessoais do aluno </summary>
    public class Cabinet
    {
        /// <summary>Número identificador do armário.</summary>
       public int NumberIdentificator { get; set; }

        /// <summary>Prédio onde está localizado.</summary>
        public Building Building { get; set; }

        /// <summary>Estudante responsável pelo armário.</summary>
        public Student Student { get; set; }

        /// <summary>Ano vigente com permisssão de uso do armário.</summary>
        public int YearValidator { get; set; }

        /// <summary>Construtor com instanciação de um armário para obter informações.</summary>
        /// <param name="numberIdentificator">Número identificador do armário.</param>
        /// <param name="building">Prédio onde está localizado.</param>
        /// <param name="student">Estudante responsável pelo armário.</param>
        /// <param name="yearValidator">Ano vigente com permisssão de uso do armário.</param>
        public Cabinet(int numberIdentificator, Building building, Student student, int yearValidator)
        {
            NumberIdentificator = numberIdentificator;
            Building = building;
            Student = student;
            YearValidator = yearValidator;
        }
    }
}