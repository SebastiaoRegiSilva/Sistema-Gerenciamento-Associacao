namespace Disparo.Plataforma.Domain.Pagamentos
{
    /// <summary>Entidade que representa os pagamentos.</summary>
    public class Pagamento
    {
        /// <summary>Ano vigente da associação à APM.</summary>
        public int Ano { get; set; }
        
        /// <summary>Valor da anuidade.</summary>
        public int Valor { get; set; }
        
        /// <summary>Matrícula do aluno que realizou o pagamento.</summary>
        public int MatriculaAluno { get; set; }
    
        /// <summary>
        /// Construtor com parâmetro para inicialização.
        /// </summary>
        /// <param name="ano">Ano vigente da associação à APM.</param>
        /// <param name="valor">Valor da anuidade.</param>
        /// <param name="matriculaAluno">Matrícula do aluno que realizou o pagamento. </param>
        public Pagamento(int ano, int valor, int matriculaAluno) 
        {
            Ano = ano;
            Valor = valor;
            MatriculaAluno = matriculaAluno;
        }
    }
}