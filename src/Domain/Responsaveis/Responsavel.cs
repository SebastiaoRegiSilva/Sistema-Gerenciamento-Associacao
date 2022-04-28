namespace Disparo.Plataforma.Domain.Responsaveis
{
    /// <summary>Objeto de valor que representa os pais ou responsáveis pelos alunos.</summary>
    public class Responsavel
    {
        /// <summary>Código de identificação de um responsável.</summary>
        public string Id { get; set; }
        
        /// <summary>Cadastro de pessoa física do responsável do aluno.</summary>
        public string Cpf { get; set; }

        /// <summary>Nome dos pais ou responsáveis.</summary>
        public string Nome { get; set; }

        /// <summary>Endereço de e-mail dos pais ou responsáveis.</summary>
        public string EnderecoEmail { get; set; }
        
        /// <summary>Construtor com parâmetros para instanciação de um responsável e suas informações.</summary>
        /// <param name="id">Código de identificação de um responsável.</param>
        /// <param name="cpf">Cadastro de pessoa físíca do responsável do aluno.</param>
        /// <param name="nome">Nome dos pais ou responsáveis.</param>
        /// <param name="enderecoEmail">Endereço de e-mail cdos pais ou responsáveis.</param>
        public Responsavel(string id, string cpf, string nome, string enderecoEmail)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            EnderecoEmail = enderecoEmail;
        }
    }
}