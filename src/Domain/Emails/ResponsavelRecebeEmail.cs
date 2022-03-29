using Disparo.Plataforma.Domain.Responsaveis;

namespace Disparo.Plataforma.Domain.Emails
{
    /// <summary>Entidade que representa o pai ou responsável do aluno que sendo receptor de um e-mail.</summary>
    public class ResponsavelRecebeEmail
    {
        /// <summary>Nome do proprietário da conta.</summary>
        public Responsavel Responsavel { get; set; }

        /// <summary>Contrutor com parâmetros para instanciação do objeto.</summary>
        /// <param name="responsavel">Nome do proprietário da conta.</param>
        public ResponsavelRecebeEmail(Responsavel responsavel)
        {
            Responsavel = responsavel;
        }
    }
}