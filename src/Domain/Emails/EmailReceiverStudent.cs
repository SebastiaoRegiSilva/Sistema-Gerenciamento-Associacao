using Disparo.Plataforma.Domain.Students;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o aluno que está sendo receptor de um e-mail.</summary>
    public class EmailReceiverStudent
    {
        /// <summary>Nome do proprietário da conta.</summary>
        public Student Student { get; set; }

        /// <summary>Contrutor com parâmetros para instanciação do objeto.</summary>
        /// <param name="student">Nome do proprietário da conta.</param>
        public EmailReceiverStudent(Student student)
        {
            Student = student;
        }
    }
}