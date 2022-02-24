namespace Disparo.Plataforma.Domain.Answerables
{
    /// <summary>Objeto de valor que representa os pais ou responsáveis pelos alunos.</summary>
    public class Answerable
    {
       /// <summary>Cadastro de pessoa física do responsável do aluno.</summary>
        public string Cpf { get; set; }

        /// <summary>Nome dos pais ou responsáveis.</summary>
        public string Name { get; set; }

        /// <summary>Endereço de e-mail dos pais ou responsáveis.</summary>
        public string AdrressEmail { get; set; }

        
        /// <summary>Construtor com parâmetros para instanciação de um responsável e suas informações.</summary>
        /// <param name="cpf">Cadastro de pessoa físíca do responsável do aluno.</param>
        /// <param name="name">Nome dos pais ou responsáveis.</param>
        /// <param name="adrressEmail">Endereço de e-mail cdos pais ou responsáveis.</param>
        public Answerable(string cpf, string name, string adrressEmail)
        {
            Cpf = cpf;
            Name = name;
            AdrressEmail = adrressEmail;
        }
    }
}