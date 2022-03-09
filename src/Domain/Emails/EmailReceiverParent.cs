using Disparo.Plataforma.Domain.Parents;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o pai ou responsável do aluno que sendo receptor de um e-mail.</summary>
    public class EmailReceiverParent
    {
        /// <summary>Nome do proprietário da conta.</summary>
        public Parent Parent { get; set; }

        /// <summary>Contrutor com parâmetros para instanciação do objeto.</summary>
        /// <param name="parent">Nome do proprietário da conta.</param>
        public EmailReceiverParent(Parent parent)
        {
            Parent = parent;
        }
    }
}