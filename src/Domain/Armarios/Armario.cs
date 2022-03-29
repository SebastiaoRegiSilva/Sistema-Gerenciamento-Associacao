using Disparo.Plataforma.Domain.Alunos;
using Domain.Plataforma.Domain.Predios;

namespace Disparo.Plataforma.Domain.Armario
{
    /// <summary>Objeto de valor que representa um armário para guarda de objetos pessoais do aluno </summary>
    public class Armario
    {
        /// <summary>Número identificador do armário.</summary>
       public int NumeroIdentificador { get; set; }

        /// <summary>Prédio onde está localizado.</summary>
        public Predio Predio { get; set; }

        /// <summary>Estudante responsável pelo armário.</summary>
        public Aluno Aluno { get; set; }

        /// <summary>Ano vigente com permisssão de uso do armário.</summary>
        public int AnoValidade { get; set; }

        /// <summary>Construtor com instanciação de um armário para obter informações.</summary>
        /// <param name="numeroIdentificador">Número identificador do armário.</param>
        /// <param name="predio">Prédio onde está localizado.</param>
        /// <param name="aluno">Estudante responsável pelo armário.</param>
        /// <param name="anoValidade">Ano vigente com permisssão de uso do armário.</param>
        public Armario(int numeroIdentificador, Predio predio, Aluno aluno, int AnoValidade)
        {
            NumeroIdentificador = numeroIdentificador;
            Predio = predio;
            Aluno = aluno;
            AnoValidade = yearValidator;
        }
    }
}