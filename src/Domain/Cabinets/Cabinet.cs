using Disparo.Plataforma.Domain.Students;

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
    }
}