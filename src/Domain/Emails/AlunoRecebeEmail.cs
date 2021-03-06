using Disparo.Plataforma.Domain.Alunos;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o aluno que está sendo receptor de um e-mail.</summary>
    public class AlunoRecebeEmail
    {
        /// <summary>Nome do proprietário da conta.</summary>
        public Aluno Aluno { get; set; }

        /// <summary>Contrutor com parâmetros para instanciação do objeto.</summary>
        /// <param name="aluno">Nome do proprietário da conta.</param>
        public AlunoRecebeEmail(Aluno aluno)
        {
            Aluno = aluno;
        }
    }
}