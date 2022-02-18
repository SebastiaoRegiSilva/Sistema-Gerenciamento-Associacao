namespace Disparo.Plataforma.Domain.Answerables
{
    /// <summary>Entidade que representa os pais ou responsáveis pelos alunos.</summary>
    public class Answerable
    {
        /// <summary>Código de identificação do responsável ou pai do aluno.</summary>
        public int Id { get; set; }

        /// <summary>Cadastro de pessoa física do responsável do aluno.</summary>
        public string Cpf { get; set; }

        /// <summary>Nome dos pais ou responsáveis.</summary>
        public string Name { get; set; }

        /// <summary>Endereço de e-mail dos pais ou responsáveis.</summary>
        public string AdrressEmail { get; set; }

        
        /// <summary>Construtor com parâmetros para instanciação de um responsãvel e suas informações.</summary>
        /// <param name="id">Código de identificação de um responsável ou pain do aluno.</param>
        /// <param name="cpf">Cadastro de pessoa físíca do responsável do aluno.</param>
        /// <param name="name">Nome dos pais ou responsáveis.</param>
        /// <param name="adrressEmail">Endereço de e-mail cdos pais ou responsáveis.</param>
        public Answerable(int id, string cpf, string name, string adrressEmail)
        {
            Id = id;
            Cpf = cpf;
            Name = name;
            AdrressEmail = adrressEmail;
        }
    }
}